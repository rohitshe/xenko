﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System.Threading.Tasks;

namespace SiliconStudio.Presentation.Services
{
    /// <summary>
    /// An interface representing a modal dialog.
    /// </summary>
    public interface IModalDialog
    {
        /// <summary>
        /// Displays the modal dialog. This method returns a task that completes when the user close the dialog.
        /// </summary>
        /// <returns>A <see cref="DialogResult"/> value indicating how the user closed the dialog.</returns>
        Task<DialogResult> ShowModal();

        /// <summary>
        /// Gets or sets a data context for the modal dialog.
        /// </summary>
        object DataContext { get; set; }
    }
}
