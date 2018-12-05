﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// open the exe, click start
        /// </summary>
        public void firstTestRecording()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            #endregion

            // Launch '%USERPROFILE%\source\repos\SimpleWPFApplication\SimpleWPFApplication\bin\Debug\SimpleWPFApplication.exe'
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.firstTestRecordingParams.UIMainWindowWindowExePath, this.firstTestRecordingParams.UIMainWindowWindowAlternateExePath);

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(16, 6));
        }
        
        #region Properties
        public virtual firstTestRecordingParams firstTestRecordingParams
        {
            get
            {
                if ((this.mfirstTestRecordingParams == null))
                {
                    this.mfirstTestRecordingParams = new firstTestRecordingParams();
                }
                return this.mfirstTestRecordingParams;
            }
        }
        
        public UIMainWindowWindow UIMainWindowWindow
        {
            get
            {
                if ((this.mUIMainWindowWindow == null))
                {
                    this.mUIMainWindowWindow = new UIMainWindowWindow();
                }
                return this.mUIMainWindowWindow;
            }
        }
        #endregion
        
        #region Fields
        private firstTestRecordingParams mfirstTestRecordingParams;
        
        private UIMainWindowWindow mUIMainWindowWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'firstTestRecording'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class firstTestRecordingParams
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
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMainWindowWindow : WpfWindow
    {
        
        public UIMainWindowWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfButton UIStartButton
        {
            get
            {
                if ((this.mUIStartButton == null))
                {
                    this.mUIStartButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIStartButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "best_button";
                    this.mUIStartButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIStartButton;
            }
        }
        
        public WpfCheckBox UICheckBoxCheckBox
        {
            get
            {
                if ((this.mUICheckBoxCheckBox == null))
                {
                    this.mUICheckBoxCheckBox = new WpfCheckBox(this);
                    #region Search Criteria
                    this.mUICheckBoxCheckBox.SearchProperties[WpfCheckBox.PropertyNames.Name] = "CheckBox";
                    this.mUICheckBoxCheckBox.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUICheckBoxCheckBox;
            }
        }
        
        public WpfButton UIStartButton1
        {
            get
            {
                if ((this.mUIStartButton1 == null))
                {
                    this.mUIStartButton1 = new WpfButton(this);
                    #region Search Criteria
                    this.mUIStartButton1.SearchProperties[WpfButton.PropertyNames.AutomationId] = "worst_button";
                    this.mUIStartButton1.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIStartButton1;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUIStartButton;
        
        private WpfCheckBox mUICheckBoxCheckBox;
        
        private WpfButton mUIStartButton1;
        #endregion
    }
}
