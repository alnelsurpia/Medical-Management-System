'Imports System
'Imports System.Configuration

Public Class cslConfig
    'Private _ConnectionString As String
    'Private _IsChanged As Boolean = False

    ''Public Event ConnectionStringChanged()

    'Public Property ConnectionString() As String
    '    Get
    '        Return _ConnectionString
    '    End Get
    '    Set(ByVal value As String)
    '        _ConnectionString = value
    '        'SetDisplayValue()
    '    End Set
    'End Property

    ''Private Sub SetDisplayValue()
    ''    Dim f As New frmConnection(_ConnectionString)
    ''    txtConnection.Text = f.DisplayValue
    ''End Sub

    'Public Sub SaveChange(ByVal connectionName As String)
    '    'Configuration.co()
    '    'Dim Config As Configuration
    '    'Dim config As System.Configuration.SettingsBase

    '    'Dim Section As ConnectionStringsSection
    '    'Dim Setting As ConnectionStringSettings
    '    'Dim ConnectionFullName As String
    '    'config.get()
    '    ''There is no inbuilt way to change application setting values in the config file.
    '    ''So that needs to be done manually by calling config section object.

    '    'Try
    '    '    'No need to bother at all if there is no change ...
    '    '    If Not _IsChanged Then Return

    '    '    'Concatenate the full settings name
    '    '    ConnectionFullName = String.Format("{0}.My.MySettings.{1}", System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, connectionName)

    '    '    'Point out the objects to manipulate
    '    '    Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    '    '    Section = CType(Config.GetSection("connectionStrings"), ConnectionStringsSection)
    '    '    Setting = Section.ConnectionStrings(ConnectionFullName)

    '    '    'Ensure connection setting is defined (Note: A default value must be set to save the connection setting!)
    '    '    If IsNothing(Setting) Then Throw New Exception("There is no connection with this name defined in the config file.")

    '    '    'Set value and save it to the config file
    '    '    Setting.ConnectionString = Me.ConnectionString
    '    '    Config.Save(ConfigurationSaveMode.Full)

    '    '    'The above will still not change the runtime value, so this needs to be changed explicitly.
    '    '    My.MySettings.Default.Item(connectionName) = Me.ConnectionString


    '    'Catch ex As Exception
    '    '    Throw New Exception(String.Format("Failed saving connection '{0}':{1}{2}", connectionName, vbCrLf, ex.Message), ex)
    '    'End Try
    'End Sub

    ''Private Function retriveDBConfig() As String
    ''    'Dim appSettings As NameValueCollection = ConfigurationManager.AppSettings
    ''    'AppSettingsList.DataSource = appSettings.Keys
    ''    'AppSettingsList.DataBind()
    ''    'ShowXml()

    ''    'Dim config As System.Configuration.Configuration = WebConfigurationManager.OpenWebConfiguration(path)
    ''    Dim config As System.Configuration.SettingsBase
    ''    'config.Item("connectionStrings").ToString()
    ''End Function

    ''Private Sub btnConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnection.Click
    ''    'Dim f As frmConnection

    ''    'f = New frmConnection(_ConnectionString)
    ''    'f.ShowDialog()

    ''    ''If value was successfully changed we need to make an update
    ''    'If (f.DialogResult = Windows.Forms.DialogResult.OK) AndAlso (f.ConnectionString <> _ConnectionString) Then
    ''    '    _ConnectionString = f.ConnectionString
    ''    '    txtConnection.Text = f.DisplayValue
    ''    '    _IsChanged = True
    ''    '    RaiseEvent ConnectionStringChanged()
    ''    'End If
    ''End Sub

End Class
