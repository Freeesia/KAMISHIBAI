﻿using System.Reactive.Disposables;
using Kamishibai;

namespace SampleBrowser.ViewModel.Page;

public static class WindowHandleExtensions
{
    public static async Task AddTo(this Task<IWindow> windowHandleTask, CompositeDisposable disposable)
    {
        var windowHandle = await windowHandleTask;
        disposable.Add(windowHandle);
    }
}