﻿namespace Kamishibai.Wpf;

public class ResumingEventArgs : EventArgs
{
    public ResumingEventArgs(string frameName, object sourceViewModel, object destinationViewModel)
    {
        FrameName = frameName;
        SourceViewModel = sourceViewModel;
        DestinationViewModel = destinationViewModel;
    }

    public string FrameName { get; }
    public object SourceViewModel { get; }
    public object DestinationViewModel { get; }
}