﻿#pragma checksum "C:\Users\Linh Rua\source\repos\T1809E_UWP_CXL_ASM\T1809E_UWP_CXL_ASM\Pages\RegisterPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B7C3799932D2E660B9F966AC43C47EA1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace T1809E_UWP_CXL_ASM
{
    partial class RegisterPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\RegisterPage.xaml line 32
                {
                    this.TxtfirstName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // Pages\RegisterPage.xaml line 35
                {
                    this.TxtlastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Pages\RegisterPage.xaml line 38
                {
                    this.Pwdpassword = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 5: // Pages\RegisterPage.xaml line 41
                {
                    this.confirmPassword = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                    ((global::Windows.UI.Xaml.Controls.PasswordBox)this.confirmPassword).KeyUp += this.IsPasswordConfirm;
                }
                break;
            case 6: // Pages\RegisterPage.xaml line 42
                {
                    this.pcfAlert = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Pages\RegisterPage.xaml line 45
                {
                    this.Txtaddress = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Pages\RegisterPage.xaml line 48
                {
                    this.Txtphone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.Txtphone).KeyUp += this.IsPhoneNumberValid;
                }
                break;
            case 9: // Pages\RegisterPage.xaml line 49
                {
                    this.phoneAlert = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // Pages\RegisterPage.xaml line 52
                {
                    this.Txtavatar = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // Pages\RegisterPage.xaml line 62
                {
                    this.Txtemail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.Txtemail).KeyUp += this.IsEmailValid;
                }
                break;
            case 12: // Pages\RegisterPage.xaml line 63
                {
                    this.emailAlert = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Pages\RegisterPage.xaml line 66
                {
                    this.birthday = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarDatePicker)this.birthday).DateChanged += this.Birthday_OnDateChanged;
                }
                break;
            case 14: // Pages\RegisterPage.xaml line 68
                {
                    this.NotNullAlert = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // Pages\RegisterPage.xaml line 70
                {
                    this.submit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.submit).Click += this.RegisterSubmit;
                }
                break;
            case 16: // Pages\RegisterPage.xaml line 56
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element16 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element16).Checked += this.Gender_Choose;
                }
                break;
            case 17: // Pages\RegisterPage.xaml line 57
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element17 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element17).Checked += this.Gender_Choose;
                }
                break;
            case 18: // Pages\RegisterPage.xaml line 58
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element18 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element18).Checked += this.Gender_Choose;
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
            return returnValue;
        }
    }
}
