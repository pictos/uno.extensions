﻿using Microsoft.Extensions.Logging;
using Uno.Extensions.Logging;
using Uno.Extensions.Navigation.Controls;
using Uno.Extensions.Navigation.Dialogs;

namespace Uno.Extensions.Navigation.Regions.Managers;

public class SimpleRegionManager<TControl> : BaseRegionManager
    where TControl : IViewManager
{
    private TControl Control { get; }

    private NavigationContext currentContext;

    protected override NavigationContext CurrentContext => currentContext;

    public SimpleRegionManager(ILogger<SimpleRegionManager<TControl>> logger, INavigationService navigation, IDialogFactory dialogFactory, TControl control) : base(logger, navigation, dialogFactory)
    {
        Control = control;
    }

    protected override void RegionNavigate(NavigationContext context, object viewModel)
    {
        currentContext = context;
        Logger.LazyLogDebug(() => $"Navigating to path '{context.Path}' with view '{context.Mapping?.View?.Name}'");
        Control.Show(context.Path, context.Mapping?.View, context.Data, viewModel);
    }

    public override string ToString()
    {
        return $"Simple({typeof(TControl).Name}) '{CurrentContext?.Path}'";
    }

}
