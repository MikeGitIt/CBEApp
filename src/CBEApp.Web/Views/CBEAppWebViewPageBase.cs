using Abp.Web.Mvc.Views;

namespace CBEApp.Web.Views
{
    public abstract class CBEAppWebViewPageBase : CBEAppWebViewPageBase<dynamic>
    {

    }

    public abstract class CBEAppWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected CBEAppWebViewPageBase()
        {
            LocalizationSourceName = CBEAppConsts.LocalizationSourceName;
        }
    }
}