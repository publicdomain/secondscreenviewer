// <copyright file="ScreenCaptureForm.cs" company="PublicDomain.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace PublicDomain
{
    // Directives
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Description of ScreenCaptureForm.
    /// </summary>
    public partial class ScreenCaptureForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:PublicDomain.ScreenCaptureForm"/> class.
        /// </summary>
        public ScreenCaptureForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the screen capture form form closed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnScreenCaptureFormFormClosed(object sender, FormClosedEventArgs e)
        {
            // TODO Add code.
        }

        /// <summary>
        /// Handles the topmost tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnTopmostToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code.
        }

        /// <summary>
        /// Handles the close tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCloseToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code.
        }
    }
}
