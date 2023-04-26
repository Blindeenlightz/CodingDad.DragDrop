﻿using System.Windows;

namespace CodingDad.DragAndDrop
{
    /// <summary>
    /// Interface implemented by the root element finder.
    /// </summary>
    public interface IRootElementFinder
    {
        /// <summary>
        /// Gets the root element.
        /// </summary>
        /// <param name="visual">The visual element to find the root for.</param>
        /// <returns>The root element.</returns>
        UIElement FindRoot (DependencyObject visual);
    }
}