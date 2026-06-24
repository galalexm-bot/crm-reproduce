// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.PermissionRoleType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>Точка расширения для создания ролей-типов</summary>
  public class PermissionRoleType
  {
    private readonly string nameForLocalization;
    internal static PermissionRoleType agmUvlBjnBVsB4sbmtl9;

    public PermissionRoleType(Guid id, string name, string image)
    {
      PermissionRoleType.k0cgcEBje3M0oMZZ0Ktp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.nameForLocalization = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 2 : 3;
            continue;
          case 2:
            this.Id = id;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
            continue;
          case 3:
            this.Image = image;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    public PermissionRoleType(Guid id, string name)
    {
      PermissionRoleType.k0cgcEBje3M0oMZZ0Ktp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Id = id;
            num = 2;
            continue;
          case 2:
            this.nameForLocalization = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    public PermissionRoleType(Guid id, string name, Type linkedEntityType, string image)
    {
      PermissionRoleType.k0cgcEBje3M0oMZZ0Ktp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.Id = id;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          case 3:
            this.Image = image;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
            continue;
          case 4:
            this.LinkedEntityType = linkedEntityType;
            num = 3;
            continue;
          default:
            this.nameForLocalization = name;
            num = 4;
            continue;
        }
      }
label_2:;
    }

    public PermissionRoleType(
      Guid id,
      string name,
      Type linkedEntityType,
      string image,
      string entityUrl)
    {
      PermissionRoleType.k0cgcEBje3M0oMZZ0Ktp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.nameForLocalization = name;
            num = 4;
            continue;
          case 2:
            this.Image = image;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 3;
            continue;
          case 3:
            this.EntityUrl = entityUrl;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 5 : 0;
            continue;
          case 4:
            this.LinkedEntityType = linkedEntityType;
            num = 2;
            continue;
          case 5:
            goto label_3;
          default:
            this.Id = id;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public PermissionRoleType(Guid id, string name, Type linkedEntityType)
    {
      PermissionRoleType.k0cgcEBje3M0oMZZ0Ktp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Id = id;
            num = 2;
            continue;
          case 2:
            this.nameForLocalization = name;
            num = 3;
            continue;
          case 3:
            this.LinkedEntityType = linkedEntityType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    public PermissionRoleType(
      Guid id,
      string name,
      Type linkedEntityType,
      Func<object, IEntity> assignedEntityEvalutor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Id = id;
      this.nameForLocalization = name;
      this.LinkedEntityType = linkedEntityType;
      this.AssignedEntityEvalutor = assignedEntityEvalutor;
    }

    public PermissionRoleType(
      Guid id,
      string name,
      Type linkedEntityType,
      Func<object, IEntity> assignedEntityEvalutor,
      string entityUrl)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Id = id;
      this.nameForLocalization = name;
      this.LinkedEntityType = linkedEntityType;
      this.AssignedEntityEvalutor = assignedEntityEvalutor;
      this.EntityUrl = entityUrl;
    }

    public PermissionRoleType(
      Guid id,
      string name,
      Type linkedEntityType,
      Func<object, IEntity> assignedEntityEvalutor,
      string image,
      string entityUrl)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Id = id;
      this.nameForLocalization = name;
      this.LinkedEntityType = linkedEntityType;
      this.AssignedEntityEvalutor = assignedEntityEvalutor;
      this.Image = image;
      this.EntityUrl = entityUrl;
    }

    /// <summary>Уникальный идентификатор</summary>
    public Guid Id
    {
      get => this.\u003CId\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public Guid UID => this.Id;

    /// <summary>
    /// Фцнкция получения значения сущности для Роли, например для роли "Автор" это будет (e) =&gt; (IEntity)a.Author
    /// </summary>
    public Func<object, IEntity> AssignedEntityEvalutor { get; private set; }

    /// <summary>Название</summary>
    public string Name => EleWise.ELMA.SR.T(this.nameForLocalization);

    /// <summary>Тип связанной сущности, например, User или UserGroup</summary>
    public Type LinkedEntityType
    {
      get => this.\u003CLinkedEntityType\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CLinkedEntityType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public override string ToString() => (string) PermissionRoleType.DINOj4BjPEQ57t6xrKFm((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082446214), (object) this.Id, (object) this.Name);

    public string Image
    {
      get => this.\u003CImage\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CImage\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public string EntityUrl
    {
      get => this.\u003CEntityUrl\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CEntityUrl\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static void k0cgcEBje3M0oMZZ0Ktp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool kZBTZYBjOl13QRcTW056() => PermissionRoleType.agmUvlBjnBVsB4sbmtl9 == null;

    internal static PermissionRoleType KgHSasBj2FPilbxAlqZ3() => PermissionRoleType.agmUvlBjnBVsB4sbmtl9;

    internal static object DINOj4BjPEQ57t6xrKFm([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);
  }
}
