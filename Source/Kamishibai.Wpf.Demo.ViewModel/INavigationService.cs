﻿using Kamishibai.Wpf.ViewModel;

namespace Kamishibai.Wpf.Demo.ViewModel;

public interface INavigationService
{
    public Task<bool> NavigateAsync<TViewModel>(string frameName = INavigationFrame.DefaultFrameName) where TViewModel : class;
    public Task<bool> NavigateAsync<TViewModel>(TViewModel viewModel, string frameName = INavigationFrame.DefaultFrameName) where TViewModel : class;
    public Task<bool> NavigateAsync<TViewModel>(Action<TViewModel> init, string frameName = INavigationFrame.DefaultFrameName) where TViewModel : class;
    Task<bool> NavigateToSafeContentPage(int count, string frameName = INavigationFrame.DefaultFrameName);
    Task<bool> GoBackAsync(string frameName = INavigationFrame.DefaultFrameName);
}