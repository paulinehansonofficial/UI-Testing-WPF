namespace CodedUITestProject
{
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;

    public partial class UIMap
    {

        /// <summary>
        /// ButtonClick - Use 'ButtonClickParams' to pass parameters into this method.
        /// </summary>
        /// 
        public UIMap()
        {
            this.UIMainWindowWindow.UIStartButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "worst_button";
        }

        public void ModifiedButtonClick()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            #endregion

            // Launch '%USERPROFILE%\source\repos\SimpleWPFApplication\SimpleWPFApplication\bin\Debug\SimpleWPFApplication.exe'
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.ButtonClickParams.UIMainWindowWindowExePath, 
                this.ButtonClickParams.UIMainWindowWindowAlternateExePath);

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(50, 8));

            uICheckBoxCheckBox.WaitForControlEnabled();

            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.ButtonClickParams.UICheckBoxCheckBoxChecked;
        }

        public virtual ButtonClickParams ButtonClickParams
        {
            get
            {
                if ((this.mButtonClickParams == null))
                {
                    this.mButtonClickParams = new ButtonClickParams();
                }
                return this.mButtonClickParams;
            }
        }

        private ButtonClickParams mButtonClickParams;
    }
    /// <summary>
    /// Parameters to be passed into 'ButtonClick'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class ButtonClickParams
    {

        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\source\repos\SimpleWPFApplication\SimpleWPFApplication\bin\Debug\SimpleWPFApplication.exe'
        /// </summary>
        public string UIMainWindowWindowExePath = "C:\\Users\\miche\\source\\repos\\SimpleWPFApplication\\SimpleWPFApplication\\bin\\Debug\\S" +
            "impleWPFApplication.exe";

        /// <summary>
        /// Launch '%USERPROFILE%\source\repos\SimpleWPFApplication\SimpleWPFApplication\bin\Debug\SimpleWPFApplication.exe'
        /// </summary>
        public string UIMainWindowWindowAlternateExePath = "%USERPROFILE%\\source\\repos\\SimpleWPFApplication\\SimpleWPFApplication\\bin\\Debug\\Si" +
            "mpleWPFApplication.exe";

        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
}
