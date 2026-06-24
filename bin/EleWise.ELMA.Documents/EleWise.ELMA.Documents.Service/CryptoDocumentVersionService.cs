using System;
using System.Web;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Services;

[Component(Order = 100)]
internal sealed class CryptoDocumentVersionService : ICryptoContextAuthServiceImpl
{
	public const string Region = "CryptoDocumentVersionService";

	public const string KeyPrefix = "CryptoDocumentVersion";

	private static readonly TimeSpan validTokenTime = new TimeSpan(0, 0, 5, 0);

	public ICacheService CacheService { get; set; }

	public IAuthenticationService AuthenticationService { get; set; }

	public ISessionBoundVariableService SessionService { get; set; }

	public bool CheckType(IEntity entity)
	{
		return entity.CastAsRealType() is IDocumentVersion;
	}

	public bool SignInForEntity(IEntity entity, string password)
	{
		IDocumentVersion documentVersion = (IDocumentVersion)entity;
		if (!DocumentVersionManager.Instance.CheckPassword(documentVersion, password))
		{
			return false;
		}
		string passwordHash = EncryptionHelper.EncryptPwd(password);
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		EncryptDocumentPasswordToken value = new EncryptDocumentPasswordToken
		{
			PasswordHash = passwordHash,
			DateCreate = DateTime.Now
		};
		string name = string.Format("{0}{1}", "CryptoDocumentVersion", documentVersion.Id);
		SessionService.Set(name, value);
		string key = string.Format("{0}_dv{1}_u{2}", "CryptoDocumentVersion", documentVersion.Id, currentUser.Id);
		CacheService.Insert(key, value);
		return true;
	}

	public bool IsSignForEntity(IEntity entity)
	{
		IDocumentVersion documentVersion = (IDocumentVersion)entity;
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		string text = string.Format("{0}{1}", "CryptoDocumentVersion", documentVersion.Id);
		DateTime now = DateTime.Now;
		if (SessionService.TryGetValue<EncryptDocumentPasswordToken>(text, out var value) && value != null)
		{
			if (now - value.DateCreate > validTokenTime)
			{
				SessionService.Remove(text);
				return false;
			}
			bool num = DocumentVersionManager.Instance.CheckPassword(documentVersion, EncryptionHelper.DecryptPwd(value.PasswordHash));
			if (num)
			{
				value.DateCreate = now;
			}
			return num;
		}
		string key = string.Format("{0}_dv{1}_u{2}", "CryptoDocumentVersion", documentVersion.Id, currentUser.Id);
		if (CacheService.TryGetValue<EncryptDocumentPasswordToken>(key, out value))
		{
			if (now - value.DateCreate > validTokenTime)
			{
				CacheService.Remove(key);
				return false;
			}
			SessionService.Set(text, value);
			bool num2 = DocumentVersionManager.Instance.CheckPassword(documentVersion, EncryptionHelper.DecryptPwd(value.PasswordHash));
			if (num2)
			{
				value.DateCreate = now;
			}
			return num2;
		}
		return false;
	}

	public void SignOutForEntity(IEntity entity)
	{
		IDocumentVersion documentVersion = (IDocumentVersion)entity;
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		string key = string.Format("{0}{1}", "CryptoDocumentVersion", documentVersion.Id);
		SessionService.Remove(key);
		string key2 = string.Format("{0}_dv{1}_u{2}", "CryptoDocumentVersion", documentVersion.Id, currentUser.Id);
		CacheService.Remove(key2);
	}

	public IEntity DecryptFromContext(IEntity entity)
	{
		IDocumentVersion documentVersion = (IDocumentVersion)entity;
		if (!IsSignForEntity(documentVersion))
		{
			return documentVersion;
		}
		string passwordFromContext = GetPasswordFromContext(documentVersion);
		if (DocumentVersionManager.Instance.DecryptInternal(documentVersion, passwordFromContext) is HtmlString content)
		{
			documentVersion.Content = content;
		}
		return documentVersion;
	}

	public string GetPasswordFromContext(IEntity entity)
	{
		IDocumentVersion documentVersion = (IDocumentVersion)entity;
		if (!IsSignForEntity(documentVersion))
		{
			return null;
		}
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		string name = string.Format("{0}{1}", "CryptoDocumentVersion", documentVersion.Id);
		if (SessionService.TryGetValue<EncryptDocumentPasswordToken>(name, out var value) && value != null)
		{
			return EncryptionHelper.DecryptPwd(value.PasswordHash);
		}
		string key = string.Format("{0}_dv{1}_u{2}", "CryptoDocumentVersion", documentVersion.Id, currentUser.Id);
		if (CacheService.TryGetValue<EncryptDocumentPasswordToken>(key, out value))
		{
			SessionService.Set(name, value);
			return EncryptionHelper.DecryptPwd(value.PasswordHash);
		}
		return null;
	}
}
