﻿using System;
using Dock.Model.Core;
using Dock.Model.Core.Events;

namespace Dock.Model
{
    /// <summary>
    /// Factory base class.
    /// </summary>
    public abstract partial class FactoryBase
    {
        /// <inheritdoc />
        public event EventHandler<ActiveDockableChangedEventArgs>? ActiveDockableChanged;

        /// <inheritdoc />
        public event EventHandler<FocusedDockableChangedEventArgs>? FocusedDockableChanged;

        /// <inheritdoc />
        public event EventHandler<DockableAddedEventArgs>? DockableAdded;

        /// <inheritdoc />
        public event EventHandler<DockableRemovedEventArgs>? DockableRemoved;

        /// <inheritdoc />
        public event EventHandler<DockableMovedEventArgs>? DockableMoved;

        /// <inheritdoc />
        public event EventHandler<DockableSwappedEventArgs>? DockableSwapped;

        /// <inheritdoc />
        public event EventHandler<DockablePinnedEventArgs>? DockablePinned;

        /// <inheritdoc />
        public event EventHandler<DockableUnpinnedEventArgs>? DockableUnpinned;

        /// <inheritdoc />
        public event EventHandler<WindowAddedEventArgs>? WindowAdded;

        /// <inheritdoc />
        public event EventHandler<WindowRemovedEventArgs>? WindowRemoved;

        /// <inheritdoc />
        public virtual void OnActiveDockableChanged(IDockable? dockable)
        {
            ActiveDockableChanged?.Invoke(this, new ActiveDockableChangedEventArgs(dockable));
        }

        /// <inheritdoc />
        public virtual void OnFocusedDockableChanged(IDockable? dockable)
        {
            FocusedDockableChanged?.Invoke(this, new FocusedDockableChangedEventArgs(dockable));
        }

        /// <inheritdoc />
        public virtual void OnDockableAdded(IDockable? dockable)
        {
            DockableAdded?.Invoke(this, new DockableAddedEventArgs(dockable));
        }

        /// <inheritdoc />
        public virtual void OnDockableRemoved(IDockable? dockable)
        {
            DockableRemoved?.Invoke(this, new DockableRemovedEventArgs(dockable));
        }

        /// <inheritdoc />
        public virtual void OnDockableMoved(IDockable? dockable)
        {
            DockableMoved?.Invoke(this, new DockableMovedEventArgs(dockable));
        }

        /// <inheritdoc />
        public virtual void OnDockableSwapped(IDockable? dockable)
        {
            DockableSwapped?.Invoke(this, new DockableSwappedEventArgs(dockable));
        }

        /// <inheritdoc />
        public virtual void OnDockablePinned(IDockable? dockable)
        {
            DockablePinned?.Invoke(this, new DockablePinnedEventArgs(dockable));
        }
 
      
        /// <inheritdoc />
        public virtual void OnDockableUnpinned(IDockable? dockable)
        {
            DockableUnpinned?.Invoke(this, new DockableUnpinnedEventArgs(dockable));
        }

        /// <inheritdoc />
        public virtual void OnWindowAdded(IDockWindow? window)
        {
            WindowAdded?.Invoke(this, new WindowAddedEventArgs(window));
        }

        /// <inheritdoc />
        public virtual void OnWindowRemoved(IDockWindow? window)
        {
            WindowRemoved?.Invoke(this, new WindowRemovedEventArgs(window));
        }
    }
}
