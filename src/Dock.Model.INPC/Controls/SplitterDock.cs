﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Dock.Model.Controls
{
    /// <summary>
    /// Splitter dock.
    /// </summary>
    public class SplitterDock : DockBase, ISplitterDock
    {
        public IView FocusedView { get; set; }
    }
}
