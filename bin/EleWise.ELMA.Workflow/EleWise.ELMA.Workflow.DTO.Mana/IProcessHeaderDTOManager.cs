using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public interface IProcessHeaderDTOManager : IConfigurationService
{
	ProcessHeaderDTO LoadOrNull(long id);

	ProcessHeaderDTO LoadOrNull(Guid uid);

	ProcessHeaderDTO Save(ProcessHeaderDTO header);

	void Publish(ProcessHeaderDTO processHeader, string comment);

	void Publish(ProcessHeaderDTO[] processHeaders, string comment);

	void Publish(ProcessHeaderDTO[] processHeaders, string comment, bool generateDocumentation);

	void Unpublish(long[] processHeaderIds);

	void Delete(long headerId);

	void Restore(ProcessHeaderDTO header);

	bool CheckProcessName(long id, long parentId, string name, out string errorMessage);

	bool CheckProcessClassName(long id, long parentId, string name, out string errorMessage);

	bool CheckProcessTableName(long id, long parentId, string name, out string errorMessage);

	bool CheckProcessMetricTableName(long id, long parentId, string name, out string errorMessage);

	bool CheckProcessInstanceMetricsTableName(long id, long parentId, string name, out string errorMessage);

	List<ProcessHeaderDTO> FindAll(string searchString);

	List<ProcessInstanceStatistics> GetExecutingInstanceStatistics(bool onlyObsolete = false);

	ProcessInstanceStatistics GetProcessExecutingInstanceStatistics(long headerId, bool onlyObsolete = false);

	long GetPublishingVersionNumber(long headerId);

	List<ProcessHeaderDTO> FindDeleted();

	long GetDeletedCount();

	List<ProcessHeaderDTO> LoadSubProcesses(ProcessHeaderDTO header);

	bool ValidateTableName(Guid ownerUid, string tableName, out string message);

	bool ValidateClassName(string className, out string message);

	long GetPublishedId(long headerId);

	List<Guid> GetPublishedPropertyUids(long headerId);

	List<Guid> GetPublishedMetricUids(long headerId);

	List<ProcessHeaderDTO> GetSubprocessTreeList(ProcessHeaderDTO header, bool onlyExternal = false);

	ProcessCommonStatistics GetCommonStatistics(bool calculateExecutingCount);

	List<Guid> GetPublishedPropertySubTypeUid(long headerId);
}
