using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Projects.Models.Resources;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Db;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Calendar.Db;

public class CalendarDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => Guid.Empty;

	public override Type[] References => new Type[1] { typeof(SecurityDbStructure) };

	public void ScheduleXmlToBase()
	{
		string productionScheduleFileName = GetProductionScheduleFileName();
		XmlDocument xmlDocument = new XmlDocument();
		bool flag = false;
		if (File.Exists(productionScheduleFileName))
		{
			try
			{
				xmlDocument.Load(productionScheduleFileName);
				flag = true;
			}
			catch (Exception exception)
			{
				Logger.Log.Error($"Production schedule xml-file {productionScheduleFileName} loading error", exception);
			}
		}
		if (flag)
		{
			SaveScheduleFromXml(xmlDocument);
		}
		else
		{
			CreateGlobalProductionSchedule();
		}
	}

	private void SaveScheduleFromXml(XmlDocument docXml)
	{
		if (ResourceCalendarManager.Instance.LoadOrNull(CalendarConstants.GlobalProductionScheduleEntityUid) != null)
		{
			return;
		}
		try
		{
			IResourceCalendar resourceCalendar = ResourceCalendarManager.Instance.Create();
			resourceCalendar.Uid = CalendarConstants.GlobalProductionScheduleEntityUid;
			resourceCalendar.Name = SR.T("Глобальный производственный календарь");
			resourceCalendar.IsCatalog = false;
			List<IBaseTimeInterval> list = new List<IBaseTimeInterval>();
			List<IWorkTimeInterval> list2 = new List<IWorkTimeInterval>();
			List<IHolidayInterval> list3 = new List<IHolidayInterval>();
			TimeSpan result = TimeSpan.Zero;
			TimeSpan result2 = TimeSpan.Zero;
			TimeSpan result3 = TimeSpan.Zero;
			TimeSpan result4 = TimeSpan.Zero;
			if (docXml == null)
			{
				throw new ArgumentNullException(SR.T("XML-документ производственного календаря - \"null\""));
			}
			XmlNode xmlNode = docXml.FirstChild;
			while (xmlNode != null && xmlNode.Name != "schedule")
			{
				xmlNode = xmlNode.NextSibling;
			}
			if (xmlNode == null)
			{
				throw new Exception(SR.T("Ошибка формата-файла производственного календаря"));
			}
			XmlNode firstChild = xmlNode.FirstChild;
			if (firstChild != null && firstChild.Name == "workDays")
			{
				if (firstChild.Attributes["workStart"] != null && !TimeSpan.TryParse(firstChild.Attributes["workStart"].Value, CultureInfo.InvariantCulture, out result))
				{
					TimeSpan.TryParse(firstChild.Attributes["workStart"].Value, out result);
				}
				if (firstChild.Attributes["workEnd"] != null && !TimeSpan.TryParse(firstChild.Attributes["workEnd"].Value, CultureInfo.InvariantCulture, out result2))
				{
					TimeSpan.TryParse(firstChild.Attributes["workEnd"].Value, out result2);
				}
				if (firstChild.Attributes["dinner"] != null && firstChild.Attributes["dinner"].Value == "false")
				{
					result3 = result.Add(new TimeSpan(0, 0, 1));
					result4 = result.Add(new TimeSpan(0, 0, 1));
				}
				else
				{
					if (firstChild.Attributes["dinnerStart"] != null && !TimeSpan.TryParse(firstChild.Attributes["dinnerStart"].Value, CultureInfo.InvariantCulture, out result3))
					{
						TimeSpan.TryParse(firstChild.Attributes["dinnerStart"].Value, out result3);
					}
					if (firstChild.Attributes["dinnerEnd"] != null && !TimeSpan.TryParse(firstChild.Attributes["dinnerEnd"].Value, CultureInfo.InvariantCulture, out result4))
					{
						TimeSpan.TryParse(firstChild.Attributes["dinnerEnd"].Value, out result4);
					}
				}
				if (result != TimeSpan.Zero && result2 != TimeSpan.Zero && result3 != TimeSpan.Zero && result4 != TimeSpan.Zero)
				{
					if (result3 == result4)
					{
						IBaseTimeInterval baseTimeInterval = EntityManager<IBaseTimeInterval>.Instance.Create();
						baseTimeInterval.Calendar = resourceCalendar;
						baseTimeInterval.Start = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result).ToRuntimeDateTimeFromServer();
						baseTimeInterval.Finish = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result2).ToRuntimeDateTimeFromServer();
						list.Add(baseTimeInterval);
					}
					else
					{
						IBaseTimeInterval baseTimeInterval2 = EntityManager<IBaseTimeInterval>.Instance.Create();
						baseTimeInterval2.Calendar = resourceCalendar;
						baseTimeInterval2.Start = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result).ToRuntimeDateTimeFromServer();
						baseTimeInterval2.Finish = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result3).ToRuntimeDateTimeFromServer();
						list.Add(baseTimeInterval2);
						IBaseTimeInterval baseTimeInterval3 = EntityManager<IBaseTimeInterval>.Instance.Create();
						baseTimeInterval3.Calendar = resourceCalendar;
						baseTimeInterval3.Start = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result4).ToRuntimeDateTimeFromServer();
						baseTimeInterval3.Finish = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result2).ToRuntimeDateTimeFromServer();
						list.Add(baseTimeInterval3);
					}
				}
				for (XmlNode xmlNode2 = firstChild.FirstChild; xmlNode2 != null; xmlNode2 = xmlNode2.NextSibling)
				{
					if (xmlNode2.Name == "day")
					{
						int result5 = 0;
						if (xmlNode2.Attributes["dayOfWeek"] != null)
						{
							int.TryParse(xmlNode2.Attributes["dayOfWeek"].Value, out result5);
						}
						if (result5 > 0 && result5 <= 7 && xmlNode2.Attributes["state"] != null)
						{
							string text = xmlNode2.Attributes["state"].Value.ToLower();
							if (text == "work")
							{
								if (result3 == result4)
								{
									IWorkTimeInterval workTimeInterval = EntityManager<IWorkTimeInterval>.Instance.Create();
									workTimeInterval.Calendar = resourceCalendar;
									workTimeInterval.DayOfWeek = result5;
									workTimeInterval.DateExceptionStart = null;
									workTimeInterval.DateExceptionFinish = null;
									workTimeInterval.Start = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result).ToRuntimeDateTimeFromServer();
									workTimeInterval.Finish = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result2).ToRuntimeDateTimeFromServer();
									list2.Add(workTimeInterval);
								}
								else
								{
									IWorkTimeInterval workTimeInterval2 = EntityManager<IWorkTimeInterval>.Instance.Create();
									workTimeInterval2.Calendar = resourceCalendar;
									workTimeInterval2.DayOfWeek = result5;
									workTimeInterval2.DateExceptionStart = null;
									workTimeInterval2.DateExceptionFinish = null;
									workTimeInterval2.Start = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result).ToRuntimeDateTimeFromServer();
									workTimeInterval2.Finish = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result3).ToRuntimeDateTimeFromServer();
									list2.Add(workTimeInterval2);
									IWorkTimeInterval workTimeInterval3 = EntityManager<IWorkTimeInterval>.Instance.Create();
									workTimeInterval3.Calendar = resourceCalendar;
									workTimeInterval3.DayOfWeek = result5;
									workTimeInterval3.DateExceptionStart = null;
									workTimeInterval3.DateExceptionFinish = null;
									workTimeInterval3.Start = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result4).ToRuntimeDateTimeFromServer();
									workTimeInterval3.Finish = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result2).ToRuntimeDateTimeFromServer();
									list2.Add(workTimeInterval3);
								}
							}
							if (text == "shortday")
							{
								TimeSpan result6 = new TimeSpan(9, 0, 0);
								TimeSpan result7 = new TimeSpan(18, 0, 0);
								if (xmlNode2.Attributes["workStart"] != null && !TimeSpan.TryParse(xmlNode2.Attributes["workStart"].Value, CultureInfo.InvariantCulture, out result6))
								{
									TimeSpan.TryParse(xmlNode2.Attributes["workStart"].Value, out result6);
								}
								if (xmlNode2.Attributes["workEnd"] != null && !TimeSpan.TryParse(xmlNode2.Attributes["workEnd"].Value, CultureInfo.InvariantCulture, out result7))
								{
									TimeSpan.TryParse(xmlNode2.Attributes["workEnd"].Value, out result7);
								}
								if (xmlNode2.Attributes["dinner"] != null && xmlNode2.Attributes["dinner"].Value == "false")
								{
									IWorkTimeInterval workTimeInterval4 = EntityManager<IWorkTimeInterval>.Instance.Create();
									workTimeInterval4.Calendar = resourceCalendar;
									workTimeInterval4.DayOfWeek = result5;
									workTimeInterval4.DateExceptionStart = null;
									workTimeInterval4.DateExceptionFinish = null;
									workTimeInterval4.Start = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result6).ToRuntimeDateTimeFromServer();
									workTimeInterval4.Finish = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result7).ToRuntimeDateTimeFromServer();
									list2.Add(workTimeInterval4);
								}
								else
								{
									if (xmlNode2.Attributes["dinnerStart"] != null)
									{
										if (!TimeSpan.TryParse(xmlNode2.Attributes["dinnerStart"].Value, CultureInfo.InvariantCulture, out var result8))
										{
											TimeSpan.TryParse(xmlNode2.Attributes["dinnerStart"].Value, out result8);
										}
										IWorkTimeInterval workTimeInterval5 = EntityManager<IWorkTimeInterval>.Instance.Create();
										workTimeInterval5.Calendar = resourceCalendar;
										workTimeInterval5.DayOfWeek = result5;
										workTimeInterval5.DateExceptionStart = null;
										workTimeInterval5.DateExceptionFinish = null;
										workTimeInterval5.Start = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result6).ToRuntimeDateTimeFromServer();
										workTimeInterval5.Finish = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result8).ToRuntimeDateTimeFromServer();
										list2.Add(workTimeInterval5);
									}
									if (xmlNode2.Attributes["dinnerEnd"] != null)
									{
										if (!TimeSpan.TryParse(xmlNode2.Attributes["dinnerEnd"].Value, CultureInfo.InvariantCulture, out var result9))
										{
											TimeSpan.TryParse(xmlNode2.Attributes["dinnerEnd"].Value, out result9);
										}
										IWorkTimeInterval workTimeInterval6 = EntityManager<IWorkTimeInterval>.Instance.Create();
										workTimeInterval6.Calendar = resourceCalendar;
										workTimeInterval6.DayOfWeek = result5;
										workTimeInterval6.DateExceptionStart = null;
										workTimeInterval6.DateExceptionFinish = null;
										workTimeInterval6.Start = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result9).ToRuntimeDateTimeFromServer();
										workTimeInterval6.Finish = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0).Add(result7).ToRuntimeDateTimeFromServer();
										list2.Add(workTimeInterval6);
									}
								}
							}
						}
					}
				}
			}
			firstChild = firstChild.NextSibling;
			if (firstChild != null)
			{
			}
			list.OrderBy((IBaseTimeInterval bi) => bi.Start);
			_ = from wti in list2
				orderby wti.DayOfWeek, wti.DateExceptionStart, wti.Start
				select wti;
			list3.OrderBy((IHolidayInterval hi) => hi.DateStart);
			resourceCalendar.BaseIntervals = (ISet<IBaseTimeInterval>)(object)new HashSet<IBaseTimeInterval>((IEnumerable<IBaseTimeInterval>)list);
			resourceCalendar.WorkIntervals = (ISet<IWorkTimeInterval>)(object)new HashSet<IWorkTimeInterval>((IEnumerable<IWorkTimeInterval>)list2);
			resourceCalendar.HolidayIntervals = (ISet<IHolidayInterval>)(object)new HashSet<IHolidayInterval>((IEnumerable<IHolidayInterval>)list3);
			resourceCalendar.Save();
		}
		catch (Exception exception)
		{
			Logger.Log.Error("Production schedule xml-parsing error", exception);
			CreateGlobalProductionSchedule();
		}
		IRuntimeApplication service = Locator.GetService<IRuntimeApplication>();
		string directoryName = Path.GetDirectoryName(service.Configuration.Config.FilePath);
		string path = Path.Combine(directoryName, "ProductionSchedule");
		if (Directory.Exists(path))
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				fileInfo.Delete();
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				directoryInfo2.Delete(recursive: true);
			}
			directoryInfo.Delete();
		}
	}

	private void CreateGlobalProductionSchedule()
	{
		if (ResourceCalendarManager.Instance.LoadOrNull(CalendarConstants.GlobalProductionScheduleEntityUid) != null)
		{
			return;
		}
		try
		{
			IResourceCalendar resourceCalendar = ResourceCalendarManager.Instance.Create();
			resourceCalendar.Uid = CalendarConstants.GlobalProductionScheduleEntityUid;
			resourceCalendar.Name = SR.T("Глобальный производственный календарь");
			resourceCalendar.IsCatalog = false;
			DateTime start = new DateTime(DateTime.Now.Year, 1, 1, 9, 0, 0).ToRuntimeDateTimeFromServer();
			DateTime finish = new DateTime(DateTime.Now.Year, 1, 1, 12, 0, 0).ToRuntimeDateTimeFromServer();
			DateTime start2 = new DateTime(DateTime.Now.Year, 1, 1, 13, 0, 0).ToRuntimeDateTimeFromServer();
			DateTime finish2 = new DateTime(DateTime.Now.Year, 1, 1, 18, 0, 0).ToRuntimeDateTimeFromServer();
			List<IBaseTimeInterval> list = new List<IBaseTimeInterval>();
			IBaseTimeInterval baseTimeInterval = EntityManager<IBaseTimeInterval>.Instance.Create();
			baseTimeInterval.Calendar = resourceCalendar;
			baseTimeInterval.Start = start;
			baseTimeInterval.Finish = finish;
			list.Add(baseTimeInterval);
			IBaseTimeInterval baseTimeInterval2 = EntityManager<IBaseTimeInterval>.Instance.Create();
			baseTimeInterval2.Calendar = resourceCalendar;
			baseTimeInterval2.Start = start2;
			baseTimeInterval2.Finish = finish2;
			list.Add(baseTimeInterval2);
			resourceCalendar.BaseIntervals = (ISet<IBaseTimeInterval>)(object)new HashSet<IBaseTimeInterval>((IEnumerable<IBaseTimeInterval>)list);
			ResourceCalendarManager.Instance.AddFiveDayWorkingWeekByBaseIntervals(resourceCalendar);
			resourceCalendar.Save();
		}
		catch (Exception exception)
		{
			Logger.Log.Error("Production schedule xml-parsing error", exception);
			throw;
		}
	}

	private string GetProductionScheduleFileName()
	{
		IRuntimeApplication service = Locator.GetService<IRuntimeApplication>();
		string directoryName = Path.GetDirectoryName(service.Configuration.Config.FilePath);
		string text = Path.Combine(directoryName, "ProductionSchedule");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return Path.Combine(text, "ProductionSchedule.xml");
	}

	public void FillWithBaseIntervals()
	{
		ResourceCalendarManager.Instance.FillWithBaseIntervalsByGlobalProductionSchedule();
	}

	public void ScheduleBaseToXml()
	{
		XmlDocument xmlDocument = null;
		bool flag = false;
		try
		{
			string @string = DataAccessManager.SettingsManager.GetString(CalendarConstants.ProjectAssemblyUid, "ProductionSchedule");
			if (@string != null)
			{
				xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(@string);
				flag = true;
			}
		}
		catch (Exception exception)
		{
			Logger.Log.Error(string.Format("Production schedule xml-file {0} loading error"), exception);
		}
		if (flag)
		{
			SaveScheduleFromXml(xmlDocument);
			return;
		}
		string productionScheduleFileName = GetProductionScheduleFileName();
		if (!File.Exists(productionScheduleFileName))
		{
			CreateGlobalProductionSchedule();
		}
	}

	public void DeleteCalendarEventUsersByUidEmpty()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		serviceNotNull.ExecuteNonQuery(string.Format("delete from CalendarEventPermission where {1}={0}UidParam", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("Uid")), new Dictionary<string, object> { 
		{
			"UidParam",
			Guid.Empty
		} });
		serviceNotNull.ExecuteNonQuery(string.Format("delete from CalendarEventUser where {1}={0}UidParam", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("Uid")), new Dictionary<string, object> { 
		{
			"UidParam",
			Guid.Empty
		} });
	}

	public void FillCalendarEventPeriodicalTable()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		DbModelUpdater serviceNotNull2 = Locator.GetServiceNotNull<DbModelUpdater>();
		string deletingColumnTemporaryName = serviceNotNull2.GetDeletingColumnTemporaryName("CalendarEvent", "TemplateEventId");
		if (!(deletingColumnTemporaryName == "TemplateEventId"))
		{
			serviceNotNull.ExecuteNonQuery(string.Format("INSERT INTO {0} ({1}, {2}, {3}, {4}, {5}, {6}) SELECT {1}, {13}, {7}, 0, (SELECT MAX({8}) FROM {9} ce2 WHERE ce2.{10} = ce1.{1}), {11} FROM {9} ce1 WHERE {12} = 1 OR {13} != 0", serviceNotNull.Dialect.QuoteIfNeeded("CalendarEventPeriodical"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("Period"), serviceNotNull.Dialect.QuoteIfNeeded("UntilDate"), serviceNotNull.Dialect.QuoteIfNeeded("ForwardCreated"), serviceNotNull.Dialect.QuoteIfNeeded("LastPeriodDate"), serviceNotNull.Dialect.QuoteIfNeeded("Closed"), serviceNotNull.Dialect.QuoteIfNeeded(serviceNotNull2.GetDeletingColumnTemporaryName("CalendarEvent", "Until")), serviceNotNull.Dialect.QuoteIfNeeded("StartDate"), serviceNotNull.Dialect.QuoteIfNeeded("CalendarEvent"), serviceNotNull.Dialect.QuoteIfNeeded(deletingColumnTemporaryName), serviceNotNull.Dialect.QuoteIfNeeded("Completed"), serviceNotNull.Dialect.QuoteIfNeeded(serviceNotNull2.GetDeletingColumnTemporaryName("CalendarEvent", "IsTemplate")), serviceNotNull.Dialect.QuoteIfNeeded(serviceNotNull2.GetDeletingColumnTemporaryName("CalendarEvent", "Period"))));
			EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf<ICalendarEventPeriodical>()) as EntityMetadata;
			if (serviceNotNull.ColumnExists("CalendarEvent", "TypeUid") && entityMetadata != null)
			{
				serviceNotNull.ExecuteNonQuery(string.Format("UPDATE {1} SET {2} = {0}ImplementationUid WHERE {1}.{4} in (SELECT {4} FROM {3})", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("CalendarEvent"), serviceNotNull.Dialect.QuoteIfNeeded("TypeUid"), serviceNotNull.Dialect.QuoteIfNeeded("CalendarEventPeriodical"), serviceNotNull.Dialect.QuoteIfNeeded("Id")), new Dictionary<string, object> { { "ImplementationUid", entityMetadata.ImplementationUid } });
			}
			if (serviceNotNull.ColumnExists("CalendarEvent", "TemplateEvent") && serviceNotNull.ColumnExists("CalendarEvent", deletingColumnTemporaryName))
			{
				serviceNotNull.ExecuteNonQuery(string.Format("UPDATE {0} SET {1} = ( SELECT o.{2} FROM {3} o WHERE o.id = {0}.id)", serviceNotNull.Dialect.QuoteIfNeeded("CalendarEvent"), serviceNotNull.Dialect.QuoteIfNeeded("TemplateEvent"), serviceNotNull.Dialect.QuoteIfNeeded(deletingColumnTemporaryName), serviceNotNull.Dialect.QuoteIfNeeded("CalendarEvent")));
			}
		}
	}

	public void PrepareScheduleUnique()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		Dictionary<long, long> dictionary = new Dictionary<long, long>();
		using (IDataReader dataReader = serviceNotNull.ExecuteQuery(string.Format("select {0}, min({1}) as MinId from {2} where {0} is not null group by {0} having count(*) >1", serviceNotNull.Dialect.QuoteIfNeeded("Owner"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("Schedule"))))
		{
			while (dataReader.Read())
			{
				dictionary.Add(Convert.ToInt64(dataReader["Owner"]), Convert.ToInt64(dataReader["MinId"]));
			}
		}
		foreach (KeyValuePair<long, long> item in dictionary)
		{
			serviceNotNull.ExecuteNonQuery(string.Format("update {1} set {2}={0}MinId where {2} in (select {3} from {4} where {5}={0}OwnerId and {3}<>{0}MinId)", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("InternetCalendar"), serviceNotNull.Dialect.QuoteIfNeeded("Calendar"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("Schedule"), serviceNotNull.Dialect.QuoteIfNeeded("Owner")), new Dictionary<string, object>
			{
				{ "OwnerId", item.Key },
				{ "MinId", item.Value }
			});
			serviceNotNull.ExecuteNonQuery(string.Format("update M_CalendarEvent_Schedules set ScheduleId={0}MinId where ScheduleId in (select {1} from {2} where {3}={0}OwnerId and {1}<>{0}MinId)", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("Schedule"), serviceNotNull.Dialect.QuoteIfNeeded("Owner")), new Dictionary<string, object>
			{
				{ "OwnerId", item.Key },
				{ "MinId", item.Value }
			});
			serviceNotNull.ExecuteNonQuery(string.Format("update M_Relationship_Schedules set {1}={0}MinId where {1} in (select {2} from {3} where {4}={0}OwnerId and {2}<>{0}MinId)", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("Child"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("Schedule"), serviceNotNull.Dialect.QuoteIfNeeded("Owner")), new Dictionary<string, object>
			{
				{ "OwnerId", item.Key },
				{ "MinId", item.Value }
			});
			serviceNotNull.ExecuteNonQuery(string.Format("delete from ScheduleLog where {1} in (select {2} from {1} where {3}={0}OwnerId and {2}<>{0}MinId)", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("Schedule"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("Owner")), new Dictionary<string, object>
			{
				{ "OwnerId", item.Key },
				{ "MinId", item.Value }
			});
			serviceNotNull.ExecuteNonQuery(string.Format("delete from SchedulePermission where {1} in (select {2} from {1} where {3}={0}OwnerId and {2}<>{0}MinId)", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("Schedule"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("Owner")), new Dictionary<string, object>
			{
				{ "OwnerId", item.Key },
				{ "MinId", item.Value }
			});
			serviceNotNull.ExecuteNonQuery(string.Format("delete from {1} where {2}={0}OwnerId and {3}<>{0}MinId", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("Schedule"), serviceNotNull.Dialect.QuoteIfNeeded("Owner"), serviceNotNull.Dialect.QuoteIfNeeded("Id")), new Dictionary<string, object>
			{
				{ "OwnerId", item.Key },
				{ "MinId", item.Value }
			});
		}
	}
}
