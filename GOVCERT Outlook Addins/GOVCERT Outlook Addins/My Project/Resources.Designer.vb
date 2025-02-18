﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("GOVCERT_Outlook_Addins.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 1.8.0.7.
        '''</summary>
        Friend ReadOnly Property BTN_VERSIION() As String
            Get
                Return ResourceManager.GetString("BTN_VERSIION", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 
        '''----------------------Email {{EmailCounter}} - DETAILS --------------------------
        '''&lt;{{From}}&gt; [{{Subject}}]
        '''Header Information:
        '''{{HeaderDetails}}
        '''
        '''Number Of Attachments
        '''{{AttachmentCount}}
        '''.
        '''</summary>
        Friend ReadOnly Property EmailDetails() As String
            Get
                Return ResourceManager.GetString("EmailDetails", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An unexpected Error occured in GCNotify!
        '''
        '''Please send this email. This will help to improve GCNotify.
        '''
        '''
        '''Details
        '''-------
        '''GCNotify - {{Version}}
        '''
        '''Message
        '''-------
        '''{{Message}}
        '''
        '''Exception Details
        '''----------
        '''{{ExceptionDetails}}.
        '''</summary>
        Friend ReadOnly Property ErrorMail() As String
            Get
                Return ResourceManager.GetString("ErrorMail", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property logo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("logo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to [Please add your inquiry here]
        '''
        '''HostDetails
        '''{{HostDetails}}
        '''{{NetworkDetails}}
        '''.
        '''</summary>
        Friend ReadOnly Property NewMailBody() As String
            Get
                Return ResourceManager.GetString("NewMailBody", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Edit your message and then click &quot;send&quot; to send this email..
        '''</summary>
        Friend ReadOnly Property NewResendError() As String
            Get
                Return ResourceManager.GetString("NewResendError", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please Select at least one email to send. (Make sure no special items were selected.).
        '''</summary>
        Friend ReadOnly Property NoSelectionError() As String
            Get
                Return ResourceManager.GetString("NoSelectionError", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You have entered a text in this Mail.
        '''
        '''By accepting your message will be alterd..
        '''</summary>
        Friend ReadOnly Property OverWriteConfirm() As String
            Get
                Return ResourceManager.GetString("OverWriteConfirm", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please click &quot;send&quot; to send this email..
        '''</summary>
        Friend ReadOnly Property ResendError() As String
            Get
                Return ResourceManager.GetString("ResendError", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The email from: {{Email}} with the subject {{Subject}} was already detected as SPAM.
        '''
        '''Do you realy want to send this email to GOVCERT?.
        '''</summary>
        Friend ReadOnly Property SPAMDialogText() As String
            Get
                Return ResourceManager.GetString("SPAMDialogText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Dear GOVCERT,
        '''
        '''I want to forward the following emails to be analysed, as I found they look souspicious.
        '''
        '''Attachment(s):
        '''{{attachments}}
        '''
        '''HostDetails
        '''{{HostDetails}}
        '''{{NetworkDetails}}
        '''
        '''With best regards,
        '''
        '''.
        '''</summary>
        Friend ReadOnly Property SuspectBody() As String
            Get
                Return ResourceManager.GetString("SuspectBody", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
