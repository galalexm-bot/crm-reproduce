// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.DefaultFormAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут указывает идентификатор формы по умолчанию для определенного типа представления
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
  public class DefaultFormAttribute : Attribute
  {
    private ViewType viewType;
    private Guid formUid;
    private Guid actionUid;
    private Guid groupUid;
    private Guid targetUid;
    private bool deletedFromChild;
    internal static DefaultFormAttribute RL5ZpNoC3DTFvTxOKM7N;

    /// <summary>Создать атрибут</summary>
    /// <param name="viewType">Тип представления</param>
    /// <param name="formUid">Уникальный идентификатор формы</param>
    public DefaultFormAttribute(ViewType viewType, string formUid)
    {
      DefaultFormAttribute.HlKYmMoCD1VQPqv7Wx0u();
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
            this.viewType = viewType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
            continue;
          default:
            this.formUid = new Guid(formUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Создать атрибут</summary>
    /// <param name="viewType">Тип представления</param>
    /// <param name="actionUid">Уникальный идетификатор действия</param>
    /// <param name="formUid">Уникальный идентификатор формы</param>
    public DefaultFormAttribute(ViewType viewType, string actionUid, string formUid)
    {
      DefaultFormAttribute.HlKYmMoCD1VQPqv7Wx0u();
      // ISSUE: explicit constructor call
      this.\u002Ector(viewType, formUid);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.actionUid = new Guid(actionUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Создать атрибут</summary>
    /// <param name="viewType"></param>
    /// <param name="actionUid"></param>
    /// <param name="formUid"></param>
    /// <param name="groupUid"></param>
    /// <param name="targetUid"></param>
    public DefaultFormAttribute(
      ViewType viewType,
      string actionUid,
      string formUid,
      string groupUid,
      string targetUid)
    {
      DefaultFormAttribute.HlKYmMoCD1VQPqv7Wx0u();
      // ISSUE: explicit constructor call
      this.\u002Ector(viewType, actionUid, formUid);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.targetUid = new Guid(targetUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          case 2:
            this.groupUid = new Guid(groupUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Создать атрибут</summary>
    /// <param name="viewType"></param>
    /// <param name="actionUid"></param>
    /// <param name="formUid"></param>
    /// <param name="groupUid"></param>
    /// <param name="targetUid"></param>
    /// <param name="deletedFromChild"></param>
    public DefaultFormAttribute(
      ViewType viewType,
      string actionUid,
      string formUid,
      string groupUid,
      string targetUid,
      bool deletedFromChild)
    {
      DefaultFormAttribute.HlKYmMoCD1VQPqv7Wx0u();
      // ISSUE: explicit constructor call
      this.\u002Ector(viewType, actionUid, formUid, groupUid, targetUid);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.deletedFromChild = deletedFromChild;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип представления</summary>
    public ViewType ViewType => this.viewType;

    /// <summary>Uid действия</summary>
    public Guid ActionUid => this.actionUid;

    /// <summary>Уникальный идентификатор формы</summary>
    public Guid FormUid => this.formUid;

    /// <summary>Группировка</summary>
    public Guid GroupUid => this.groupUid;

    /// <summary>Классификатор</summary>
    public Guid TargetUid => this.targetUid;

    /// <summary>
    /// Если форма приходит из базового класса, но удалена в наследнике
    /// </summary>
    public bool DeletedFromChild => this.deletedFromChild;

    internal static void HlKYmMoCD1VQPqv7Wx0u() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool wwyj8CoCpgFt7qbIHf9y() => DefaultFormAttribute.RL5ZpNoC3DTFvTxOKM7N == null;

    internal static DefaultFormAttribute z3euNYoCae2OJTirf6a0() => DefaultFormAttribute.RL5ZpNoC3DTFvTxOKM7N;
  }
}
