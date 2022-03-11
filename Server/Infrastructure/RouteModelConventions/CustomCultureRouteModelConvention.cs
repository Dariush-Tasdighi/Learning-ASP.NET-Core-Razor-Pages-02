////builder.Services.AddRazorPages().AddRazorPagesOptions(options =>
////{
////	options.Conventions.Add
////		(new Infrastructure.RouteModelConventions.CustomCultureRouteModelConvention());
////});

//namespace Infrastructure.RouteModelConventions
//{
//	public class CustomCultureRouteModelConvention :
//		Microsoft.AspNetCore.Mvc.ApplicationModels.IPageRouteModelConvention
//	{
//		public CustomCultureRouteModelConvention() : base()
//		{
//		}

//		public void Apply
//			(Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModel model)
//		{
//			var newSelectorModels =
//				new System.Collections.Generic.List
//				<Microsoft.AspNetCore.Mvc.ApplicationModels.SelectorModel>();

//			foreach (var selector in model.Selectors)
//			{
//				var currentTemplate =
//					selector?.AttributeRouteModel?.Template;

//				var newTemplate =
//					$"/{{culture}}/{currentTemplate}";

//				// TODO
//				//if(selector?.AttributeRouteModel != null)
//				//{
//				//	selector.AttributeRouteModel.Template = newTemplate;
//				//}

//				var newAttributeRouteModel =
//					new Microsoft.AspNetCore.Mvc.ApplicationModels.AttributeRouteModel
//					{
//						Order = -1,
//						Template = newTemplate,
//					};

//				var newSelectorModel =
//					new Microsoft.AspNetCore.Mvc.ApplicationModels.SelectorModel
//					{
//						AttributeRouteModel = newAttributeRouteModel,
//					};

//				newSelectorModels.Add(item: newSelectorModel);
//			}

//			foreach (var selectorModel in newSelectorModels)
//			{
//				model.Selectors.Add(item: selectorModel);
//			}
//		}
//	}
//}
