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


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CustomDIR() As String
            Get
                Return CType(Me("CustomDIR"),String)
            End Get
            Set
                Me("CustomDIR") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property RenderSelection() As Integer
            Get
                Return CType(Me("RenderSelection"),Integer)
            End Get
            Set
                Me("RenderSelection") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property RenderQuality() As Integer
            Get
                Return CType(Me("RenderQuality"),Integer)
            End Get
            Set
                Me("RenderQuality") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property FlipLR() As Boolean
            Get
                Return CType(Me("FlipLR"),Boolean)
            End Get
            Set
                Me("FlipLR") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MirrorLR() As Boolean
            Get
                Return CType(Me("MirrorLR"),Boolean)
            End Get
            Set
                Me("MirrorLR") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property UpgradeRequired() As Boolean
            Get
                Return CType(Me("UpgradeRequired"),Boolean)
            End Get
            Set
                Me("UpgradeRequired") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("NewInstall")>  _
        Public Property LatestVersion() As String
            Get
                Return CType(Me("LatestVersion"),String)
            End Get
            Set
                Me("LatestVersion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("English")>  _
        Public Property UserLanguage() As String
            Get
                Return CType(Me("UserLanguage"),String)
            End Get
            Set
                Me("UserLanguage") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CustomID() As String
            Get
                Return CType(Me("CustomID"),String)
            End Get
            Set
                Me("CustomID") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UserAgreed() As Boolean
            Get
                Return CType(Me("UserAgreed"),Boolean)
            End Get
            Set
                Me("UserAgreed") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property AspectRatioList() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("AspectRatioList"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("AspectRatioList") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" encoding=""utf-16""?>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ArrayOfString xmlns:xsi=""http://www.w3."& _ 
            "org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <s"& _ 
            "tring>front|6:3|6:3|30|-1|60|True|10</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>back|6:3|6:3|32.5|57.2|"& _ 
            "52|True|13</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>left_repeater|6:3|6:3|67|51|49|True|16</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)& _ 
            "  <string>right_repeater|6:3|6:3|0|51|49|True|19</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>front|4:3|4"& _ 
            ":3|19|1|64|True|6</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>right_repeater|4:3|4:3|0|55|45|True|16</st"& _ 
            "ring>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>left_repeater|4:3|4:3|55|55|45|True|11</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>back"& _ 
            "|4:3|4:3|39|0|22|True|1</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>left_repeater|All Cameras|16:9|66|56"& _ 
            "|44|True|16</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>right_repeater|All Cameras|16:9|0|56|44|True|11<"& _ 
            "/string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>back|All Cameras|16:9|33|60|45|True|6</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>fr"& _ 
            "ont|All Cameras|16:9|27|0|61|True|1</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>front|Full Screen|4:3|0|"& _ 
            "0|100|True|1</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>right_repeater|Full Screen|4:3|0|0|100|False|6<"& _ 
            "/string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>left_repeater|Full Screen|4:3|0|0|100|False|11</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <"& _ 
            "string>back|Full Screen|4:3|0|0|100|False|16</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>back|12:3|12:3|"& _ 
            "33.3|0|100|False|6</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>front|12:3|12:3|33.3|0|100|True|1</string"& _ 
            ">"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>left_repeater|12:3|12:3|66.6|0|100|True|11</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>righ"& _ 
            "t_repeater|12:3|12:3|0|0|100|True|16</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>left_repeater|Front &am"& _ 
            "p; Left Repeater|8:3|0|0|100|True|6</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>front|Front &amp; Left R"& _ 
            "epeater|8:3|50|0|100|True|1</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>right_repeater|Front &amp; Left "& _ 
            "Repeater|8:3|0|0|100|False|11</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>back|Front &amp; Left Repeater"& _ 
            "|8:3|50|0|100|False|16</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>right_repeater|Front &amp; Right Repe"& _ 
            "ater|8:3|50|0|100|True|6</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>front|Front &amp; Right Repeater|8:"& _ 
            "3|0|0|100|True|1</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>left_repeater|Front &amp; Right Repeater|8:"& _ 
            "3|50|0|100|False|11</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>back|Front &amp; Right Repeater|8:3|0|0|"& _ 
            "100|False|16</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>left_repeater|Front &amp; Left/Right Repeater|1"& _ 
            "2:3|0|0|100|True|11</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>back|Front &amp; Left/Right Repeater|12:"& _ 
            "3|33|0|100|False|16</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>right_repeater|Front &amp; Left/Right Re"& _ 
            "peater|12:3|66|0|100|True|6</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>front|Front &amp; Left/Right Rep"& _ 
            "eater|12:3|33|0|100|True|1</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</ArrayOfString>")>  _
        Public Property UserSavedCameraLayouts() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("UserSavedCameraLayouts"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("UserSavedCameraLayouts") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property LastAspectRatio() As String
            Get
                Return CType(Me("LastAspectRatio"),String)
            End Get
            Set
                Me("LastAspectRatio") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property AspectNames() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("AspectNames"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("AspectNames") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Message() As String
            Get
                Return CType(Me("Message"),String)
            End Get
            Set
                Me("Message") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MirorBack() As Boolean
            Get
                Return CType(Me("MirorBack"),Boolean)
            End Get
            Set
                Me("MirorBack") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4")>  _
        Public Property MaxThreads() As Integer
            Get
                Return CType(Me("MaxThreads"),Integer)
            End Get
            Set
                Me("MaxThreads") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("VLC")>  _
        Public Property VideoPlayerType() As String
            Get
                Return CType(Me("VideoPlayerType"),String)
            End Get
            Set
                Me("VideoPlayerType") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.TeslaCam_Viewer.My.MySettings
            Get
                Return Global.TeslaCam_Viewer.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
