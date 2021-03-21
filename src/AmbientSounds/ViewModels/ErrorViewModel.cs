﻿namespace AmbientSounds.ViewModels
{
    /// <summary>
    /// ViewModel for an error message to be displayed
    /// usually by a WinUI InfoBar.
    /// </summary>
    public class ErrorViewModel
    {
        public ErrorViewModel(string errorId)
        {
            ErrorId = errorId;
        }

        /// <summary>
        /// An internal ID to quickly identity what type of error this.
        /// Not to be displayed.
        /// </summary>
        public string ErrorId { get; set; } = "";

        /// <summary>
        /// The message to display.
        /// </summary>
        public string ErrorMessage { get; set; } = "";
    }
}
