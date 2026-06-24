using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.Services;

public interface IEntityFormsService
{
	IEnumerable<FormViewItem> GetAllForms(ClassMetadata metadata);

	void GetBaseForms(List<FormViewItem> forms, ClassDefaultForms defaultForms, EntityMetadata metadata, Guid ignoreExtensionUid);

	void AddForms(List<FormViewItem> forms, ClassDefaultForms defaultForms, ClassMetadata metadata);

	FormViewItem AddChildForm(List<FormViewItem> forms, IEnumerable<FormViewItemTransformation> childFormTransformations, FormViewItemTransformation transform);
}
