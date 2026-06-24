// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.TablePartExtensionsContainer`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Entities
{
  public class TablePartExtensionsContainer<TItem> where TItem : IEntity
  {
    private IEntity _parent;
    internal static object prUfrmhZqSwaXCAnuMMx;

    public TablePartExtensionsContainer(IEntity parent)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            Contract.ArgumentNotNull((object) parent, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61249315));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 2 : 1;
            continue;
          case 2:
            this._parent = parent;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Родительская сущность</summary>
    public IEntity Parent => this._parent;

    /// <summary>Получить настройки свойства блока</summary>
    /// <typeparam name="TValue">Тип свойства</typeparam>
    /// <param name="expression">Выражение, описывающее свойство, для которого нужно получить настройки</param>
    /// <returns>Настройки свойства</returns>
    public TypeSettings GetSettingsFor<TValue>(Expression<Func<TItem, TValue>> expression)
    {
      IPropertyMetadata propertyMetadata = IEntityExtensions.GetPropertyMetadata(typeof (TItem), expression.Body);
      return this.Parent.GetPropertySettings(propertyMetadata.PropertyUid, propertyMetadata.Settings);
    }

    /// <summary>Получить контейнер для операций с блоком</summary>
    /// <typeparam name="TChildItem">Тип элемента внутреннего блока</typeparam>
    /// <param name="expression">Выражение, описывающее свойство, для которого нужно получить настройки</param>
    /// <returns>Настройки свойства</returns>
    public TablePartExtensionsContainer<TChildItem> ForTablePart<TChildItem>(
      Expression<Func<TItem, ISet<TChildItem>>> expression)
      where TChildItem : IEntity
    {
      return new TablePartExtensionsContainer<TChildItem>(this.Parent);
    }

    internal static bool CnnaKIhZKBbVqE9eHN6b() => TablePartExtensionsContainer<TItem>.prUfrmhZqSwaXCAnuMMx == null;

    internal static object U6MO5hhZXr2ycvPRGw52() => TablePartExtensionsContainer<TItem>.prUfrmhZqSwaXCAnuMMx;
  }
}
