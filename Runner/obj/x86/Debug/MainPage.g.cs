﻿#pragma checksum "C:\Users\haste\source\repos\ImageCropper\Runner\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7BB05D4B7AA39BEBD69B67524531354A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Runner
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Media_RotateTransform_CenterX(global::Windows.UI.Xaml.Media.RotateTransform obj, global::System.Double value)
            {
                obj.CenterX = value;
            }
            public static void Set_Windows_UI_Xaml_Media_RotateTransform_CenterY(global::Windows.UI.Xaml.Media.RotateTransform obj, global::System.Double value)
            {
                obj.CenterY = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj4_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::Controls.ImageCropper dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Media.RotateTransform obj19;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj19CenterXDisabled = false;
            private static bool isobj19CenterYDisabled = false;

            private MainPage_obj4_BindingsTracking bindingsTracking;

            public MainPage_obj4_Bindings()
            {
                this.bindingsTracking = new MainPage_obj4_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 41 && columnNumber == 136)
                {
                    isobj19CenterXDisabled = true;
                }
                else if (lineNumber == 41 && columnNumber == 181)
                {
                    isobj19CenterYDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // MainPage.xaml line 27
                        this.Initialize(); // Template children have been connected, initialize bindings
                        break;
                    case 19: // MainPage.xaml line 41
                        this.obj19 = (global::Windows.UI.Xaml.Media.RotateTransform)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Controls.ImageCropper)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Controls.ImageCropper obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ImageCenterX(obj.ImageCenterX, phase);
                        this.Update_ImageCenterY(obj.ImageCenterY, phase);
                    }
                }
            }
            private void Update_ImageCenterX(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainPage.xaml line 41
                    if (!isobj19CenterXDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Media_RotateTransform_CenterX(this.obj19, obj);
                    }
                }
            }
            private void Update_ImageCenterY(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainPage.xaml line 41
                    if (!isobj19CenterYDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Media_RotateTransform_CenterY(this.obj19, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MainPage_obj4_BindingsTracking
            {
                private global::System.WeakReference<MainPage_obj4_Bindings> weakRefToBindingObj; 

                public MainPage_obj4_BindingsTracking(MainPage_obj4_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MainPage_obj4_Bindings>(obj);
                }

                public MainPage_obj4_Bindings TryGetBindingObject()
                {
                    MainPage_obj4_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void DependencyPropertyChanged_ImageCenterX(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    MainPage_obj4_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Controls.ImageCropper obj = sender as global::Controls.ImageCropper;
                        if (obj != null)
                        {
                            bindings.Update_ImageCenterX(obj.ImageCenterX, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_ImageCenterY(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    MainPage_obj4_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Controls.ImageCropper obj = sender as global::Controls.ImageCropper;
                        if (obj != null)
                        {
                            bindings.Update_ImageCenterY(obj.ImageCenterY, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_ImageCenterX = 0;
                private long tokenDPC_ImageCenterY = 0;
                public void UpdateChildListeners_(global::Controls.ImageCropper obj)
                {
                    MainPage_obj4_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Controls.ImageCropper.ImageCenterXProperty, tokenDPC_ImageCenterX);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Controls.ImageCropper.ImageCenterYProperty, tokenDPC_ImageCenterY);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_ImageCenterX = obj.RegisterPropertyChangedCallback(global::Controls.ImageCropper.ImageCenterXProperty, DependencyPropertyChanged_ImageCenterX);
                            tokenDPC_ImageCenterY = obj.RegisterPropertyChangedCallback(global::Controls.ImageCropper.ImageCenterYProperty, DependencyPropertyChanged_ImageCenterY);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 20: // MainPage.xaml line 101
                {
                    this.imageCropper = (global::Controls.ImageCropper)(target);
                }
                break;
            case 21: // MainPage.xaml line 109
                {
                    global::Windows.UI.Xaml.Controls.Button element21 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element21).Click += this.ButtonBase_OnClick;
                }
                break;
            case 22: // MainPage.xaml line 110
                {
                    this.Slider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Slider).ValueChanged += this.Slider_OnValueChanged;
                }
                break;
            case 23: // MainPage.xaml line 111
                {
                    this.Scale = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Scale).ValueChanged += this.Scale_OnValueChanged;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 4: // MainPage.xaml line 27
                {                    
                    var templatedParent4 = target as global::Controls.ImageCropper;
                    if (templatedParent4 != null)
                    {
                        MainPage_obj4_Bindings bindings = new MainPage_obj4_Bindings();
                        returnValue = bindings;
                        bindings.SetDataRoot(templatedParent4);
                        global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(templatedParent4, bindings);
                    }
                }
                break;
            }
            return returnValue;
        }
    }
}

