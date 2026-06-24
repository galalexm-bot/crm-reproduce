using System;
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
public class CryptoDocumentService : ICryptoContextAuthServiceImpl
{
	public const string Region = "CryptoDocumentService";

	public const string KeyPrefix = "CryptoDocument";

	private static TimeSpan _validTokenTime = new TimeSpan(0, 0, 5, 0);

	public ICacheService CacheService { get; set; }

	public IAuthenticationService AuthenticationService { get; set; }

	public ISessionBoundVariableService SessionService { get; set; }

	public bool CheckType(IEntity entity)
	{
		return entity.CastAsRealType() is IDocument;
	}

	public bool SignInForEntity(IEntity entity, string password)
	{
		IDocument document = (IDocument)entity;
		if (!DocumentManager.Instance.CheckPassword(document, password, writeHistory: true))
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
		string name = string.Format("{0}{1}", "CryptoDocument", document.Id);
		SessionService.Set(name, value);
		string key = string.Format("{0}_d{1}_u{2}", "CryptoDocument", document.Id, currentUser.Id);
		CacheService.Insert(key, value);
		DocumentManager.Instance.SendEncryptPasswordEntered(document, status: true);
		return true;
	}

	public bool IsSignForEntity(IEntity entity)
	{
		IDocument document = (IDocument)entity;
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		string text = string.Format("{0}{1}", "CryptoDocument", document.Id);
		DateTime now = DateTime.Now;
		if (SessionService.TryGetValue<EncryptDocumentPasswordToken>(text, out var value) && value != null)
		{
			if (now - value.DateCreate > _validTokenTime)
			{
				SessionService.Remove(text);
				return false;
			}
			bool num = DocumentManager.Instance.CheckPassword(document, EncryptionHelper.DecryptPwd(value.PasswordHash));
			if (num)
			{
				value.DateCreate = now;
			}
			return num;
		}
		string key = string.Format("{0}_d{1}_u{2}", "CryptoDocument", document.Id, currentUser.Id);
		if (CacheService.TryGetValue<EncryptDocumentPasswordToken>(key, out value))
		{
			if (now - value.DateCreate > _validTokenTime)
			{
				CacheService.Remove(key);
				return false;
			}
			SessionService.Set(text, value);
			bool num2 = DocumentManager.Instance.CheckPassword(document, EncryptionHelper.DecryptPwd(value.PasswordHash));
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
		IDocument document = (IDocument)entity;
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		string key = string.Format("{0}{1}", "CryptoDocument", document.Id);
		SessionService.Remove(key);
		string key2 = string.Format("{0}_d{1}_u{2}", "CryptoDocument", document.Id, currentUser.Id);
		CacheService.Remove(key2);
	}

	public IEntity DecryptFromContext(IEntity entity)
	{
		IDocument document = (IDocument)entity;
		if (!IsSignForEntity(document))
		{
			return document;
		}
		string passwordFromContext = GetPasswordFromContext(document);
		return DocumentManager.Instance.Decrypt(document, passwordFromContext);
	}

	public string GetPasswordFromContext(IEntity entity)
	{
		IDocument document = (IDocument)entity;
		if (!IsSignForEntity(document))
		{
			return null;
		}
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		string name = string.Format("{0}{1}", "CryptoDocument", document.Id);
		if (SessionService.TryGetValue<EncryptDocumentPasswordToken>(name, out var value) && value != null)
		{
			return EncryptionHelper.DecryptPwd(value.PasswordHash);
		}
		string key = string.Format("{0}_d{1}_u{2}", "CryptoDocument", document.Id, currentUser.Id);
		if (CacheService.TryGetValue<EncryptDocumentPasswordToken>(key, out value))
		{
			SessionService.Set(name, value);
			return EncryptionHelper.DecryptPwd(value.PasswordHash);
		}
		return null;
	}
}
