﻿using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ProductManagement.Blazor.WebApp.Tiered;

[Dependency(ReplaceServices = true)]
public class ProductManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProductManagement";
}
