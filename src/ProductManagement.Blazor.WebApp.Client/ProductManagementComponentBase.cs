using ProductManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ProductManagement.Blazor.WebApp.Client;

public abstract class ProductManagementComponentBase : AbpComponentBase
{
    protected ProductManagementComponentBase()
    {
        LocalizationResource = typeof(ProductManagementResource);
    }
}
