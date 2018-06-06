﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Dock.Model.Controls
{
    /// <summary>
    /// Document dock.
    /// </summary>
    public class DocumentDock : DockBase, IDocumentDock
    {
        public IView FocusedView { get; set; }
    }
}
