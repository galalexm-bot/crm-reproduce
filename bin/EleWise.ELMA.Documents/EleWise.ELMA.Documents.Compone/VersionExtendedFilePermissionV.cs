using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using NHibernate;
using NHibernate.Type;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class VersionExtendedFilePermissionValidator : IExtendedFilePermissionValidator
{
	private ITransformationProvider transformationProvider;

	private ISessionProvider sessionProvider;

	private IAuthenticationService authenticationService;

	private ISecurityService securityService;

	public VersionExtendedFilePermissionValidator(ITransformationProvider transformationProvider, ISessionProvider sessionProvider, IAuthenticationService authenticationService, ISecurityService securityService)
	{
		this.transformationProvider = transformationProvider;
		this.sessionProvider = sessionProvider;
		this.authenticationService = authenticationService;
		this.securityService = securityService;
	}

	public bool HasPermission(BinaryFile file, out string errorMessage)
	{
		errorMessage = string.Empty;
		EleWise.ELMA.Security.Models.IUser currentUser = authenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		if (securityService.HasPermission(PermissionProvider.DocumentsFullAccessToAllObjectsPermission))
		{
			return true;
		}
		string text = string.Format("SELECT count({0}.{6}) as {13}, count({4}.{10}) as {14}\r\nFrom {1}\r\nLeft Join {3} on {2}.{11} = :permissionId and {2}.{7} = {0}.{6}\r\nLeft Join {5} {4} on {2}.{8} = {4}.{9} and {4}.{10} = :userId\r\nWhere {0}.{12} in (:binaryFileIds) and {0}.{6} is not null", "dv", transformationProvider.NoLockTableExpression("DocumentVersion", "dv"), "dop", transformationProvider.NoLockTableExpression("DmsObjectPermission", "dop"), "ussc", transformationProvider.Dialect.QuoteIfNeeded("UserSecuritySetCache"), transformationProvider.Dialect.QuoteIfNeeded("DocumentId"), transformationProvider.Dialect.QuoteIfNeeded("DmsObject"), transformationProvider.Dialect.QuoteIfNeeded("UserSecuritySetCacheId"), transformationProvider.Dialect.QuoteIfNeeded("SetId"), transformationProvider.Dialect.QuoteIfNeeded("UserId"), transformationProvider.Dialect.QuoteIfNeeded("PermissionId"), transformationProvider.Dialect.QuoteIfNeeded("File"), "docversions", "usscpermissions");
		ISession session = sessionProvider.GetSession("");
		List<string> list = new List<string> { file.Id };
		if (!file.SecondId.IsNullOrEmpty())
		{
			list.Add(file.SecondId);
		}
		object[] array = ((IQuery)session.CreateSQLQuery(text).AddScalar("docversions", (IType)(object)NHibernateUtil.Int64).AddScalar("usscpermissions", (IType)(object)NHibernateUtil.Int64)).SetParameter<long>("userId", currentUser.Id).SetParameter<Guid>("permissionId", PermissionProvider.DocumentLoadPermission.Id).SetParameterList("binaryFileIds", (IEnumerable)list)
			.UniqueResult<object[]>();
		if (array == null)
		{
			return true;
		}
		long[] array2 = array.Cast<long>().ToArray();
		if (array2.Length == 2 && array2[0] > 0 && array2[1] == 0L)
		{
			errorMessage = SR.T("Недостаточно прав доступа к файлу \"{0}\". Отсутствует привилегия \"Загрузка\".", file.Name);
			return false;
		}
		return true;
	}
}
