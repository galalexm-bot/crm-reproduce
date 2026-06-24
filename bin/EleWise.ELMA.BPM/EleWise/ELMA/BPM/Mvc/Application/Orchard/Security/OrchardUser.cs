// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPM.Mvc.Application.Orchard.Security.OrchardUser
// Assembly: EleWise.ELMA.BPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EE1B80B5-F464-4FFF-85CF-6A69B66F676D
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.xml

using j3AmrhgkCleVTGdEwA;
using Orchard.ContentManagement;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.BPM.Mvc.Application.Orchard.Security
{
  /// <summary>Польльвоатель Orchard</summary>
  public class OrchardUser : Orchard.Security.IUser, IContent
  {
    private readonly string userName;
    private readonly string email;
    private readonly long id;
    private ContentItem contentItem;
    internal static OrchardUser yqbZ7FAS6rGITiDbqku;

    /// <summary>Ctor</summary>
    /// <param name="elmaUser">Пользователь ELMA</param>
    public OrchardUser(EleWise.ELMA.Security.Models.IUser elmaUser)
    {
      TKW1L3mlUyvXmg29jA.RWk58XigPN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.id = elmaUser.Id;
            num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_2af84c7d16434d6bb9d7477c8de31530 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.userName = (string) OrchardUser.i6SO8RALycRM14sRNAb((object) elmaUser);
            num = 4;
            continue;
          case 4:
            this.email = (string) OrchardUser.HdR0weAlhxOmihaWbrW((object) elmaUser);
            num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_8853073cf3be43d7893825ef174925e7 == 0 ? 0 : 1;
            continue;
          default:
            this.contentItem = new ContentItem();
            num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_aa54a61f50a144bab587b55f0c6b0d70 == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Элемент</summary>
    public ContentItem ContentItem => this.contentItem;

    /// <summary>Идентификатор</summary>
    public int Id => (int) this.id;

    /// <summary>Имя пользователя</summary>
    public string UserName => this.userName;

    /// <summary>Электронная почта</summary>
    public string Email => this.email;

    internal static object i6SO8RALycRM14sRNAb([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.IUser) obj0).UserName;

    internal static object HdR0weAlhxOmihaWbrW([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.IUser) obj0).EMail;

    internal static bool UZmceDATp5POCjYKUfo() => OrchardUser.yqbZ7FAS6rGITiDbqku == null;

    internal static OrchardUser cMnrYFA4fKU8ydA99wZ() => OrchardUser.yqbZ7FAS6rGITiDbqku;
  }
}
