﻿using ProductManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ProductManagement.Blazor.Client;

public abstract class ProductManagementComponentBase : AbpComponentBase
{
    protected ProductManagementComponentBase()
    {
        LocalizationResource = typeof(ProductManagementResource);
    }
}
