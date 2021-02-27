'------------------------------------------------------------------------------
' Clase para manejar ficheros de configuración                      (15/Nov/05)
'
' Las secciones siempre estarán dentro de <configuration>
' al menos así lo guardará esta clase, aunque permite leer pares key / value.
' Para que se sepa que se lee de configuration,
' en el código se indica explícitamente.
'
' Basada en mi código publicado el 27/Feb/05 en:
' http://www.elguille.info/NET/dotnet/appSettings2.htm
' Pero para usarla de forma independiente de ConfigurationSettings
'
' ©Guillermo 'guille' Som, 2005
'------------------------------------------------------------------------------
Option Explicit On 
Option Strict On

Imports Microsoft.VisualBasic
'Imports vb = Microsoft.VisualBasic
Imports System

Imports System.Collections
Imports System.Configuration
Imports System.Xml
Imports System.IO

Namespace elGuille.Util
    Public Class Config

        '----------------------------------------------------------------------
        ' Los campos y métodos privados
        '----------------------------------------------------------------------
        Private Const configuration As String = "configuration/"
        Private ficConfig As String = ""
        Private configXml As New XmlDocument

        Public Function GetValue(ByVal seccion As String, ByVal clave As String) As String
            Return GetValue(seccion, clave, "")
        End Function
        Public Function GetValue(ByVal seccion As String, ByVal clave As String, ByVal predeterminado As String) As String
            Return cfgGetValue(seccion, clave, predeterminado)
            'Return cfgGetValue("configuration/" & seccion, clave, predeterminado)
        End Function
        Public Function GetValue(ByVal seccion As String, ByVal clave As String, ByVal predeterminado As Integer) As Integer
            Return CInt(cfgGetValue(seccion, clave, predeterminado.ToString))
        End Function
        Public Function GetValue(ByVal seccion As String, ByVal clave As String, ByVal predeterminado As Boolean) As Boolean
            Dim def As String = "0"
            If predeterminado Then def = "1"
            def = cfgGetValue(seccion, clave, def)
            If def = "1" Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Sub SetValue(ByVal seccion As String, ByVal clave As String, ByVal valor As String)
            'cfgSetValue("configuration/" & seccion, clave, valor)
            cfgSetValue(seccion, clave, valor)
        End Sub
        Public Sub SetValue(ByVal seccion As String, ByVal clave As String, ByVal valor As Integer)
            cfgSetValue(seccion, clave, valor.ToString)
        End Sub
        Public Sub SetValue(ByVal seccion As String, ByVal clave As String, ByVal valor As Boolean)
            If valor Then
                cfgSetValue(seccion, clave, "1")
            Else
                cfgSetValue(seccion, clave, "0")
            End If
        End Sub

        Public Sub SetKeyValue(ByVal seccion As String, ByVal clave As String, ByVal valor As String)
            cfgSetKeyValue(seccion, clave, valor)
        End Sub
        Public Sub SetKeyValue(ByVal seccion As String, ByVal clave As String, ByVal valor As Integer)
            cfgSetKeyValue(seccion, clave, valor.ToString)
        End Sub
        Public Sub SetKeyValue(ByVal seccion As String, ByVal clave As String, ByVal valor As Boolean)
            If valor Then
                cfgSetKeyValue(seccion, clave, "1")
            Else
                cfgSetKeyValue(seccion, clave, "0")
            End If
        End Sub

        ' Elimina la sección, en realidad la deja vacía
        Public Sub RemoveSection(ByVal seccion As String)
            Dim n As XmlNode
            n = configXml.SelectSingleNode(configuration & seccion)
            If Not n Is Nothing Then
                n.RemoveAll()
            End If
        End Sub

        ' Guardar el fichero de configuración
        ' Si no se llama a este método, no se guardará de forma permanente.
        Public Sub Save()
            configXml.Save(ficConfig)
        End Sub

        ' Leer el fichero de configuración
        ' Si no existe, se crea uno nuevo
        Public Sub Read()
            Dim fic As String = ficConfig
            If File.Exists(fic) Then
                configXml.Load(fic)
            Else
                ' Crear el XML de configuración con la sección General
                Dim sb As New System.Text.StringBuilder
                sb.Append("<?xml version=""1.0"" encoding=""utf-8"" ?>")
                sb.Append("<configuration>")
                ' Por si es un fichero appSetting
                sb.Append("<configSections>")
                sb.Append("<section name=""General"" type=""System.Configuration.DictionarySectionHandler"" />")
                sb.Append("</configSections>")
                sb.Append("<General>")
                sb.Append("<!-- Los valores irán dentro del elemento indicado por la clave -->")
                sb.Append("<!-- Aunque también se podrán indicar como pares key / value -->")
                'sb.Append("<add key=""Copyright"" value=""©Guillermo 'guille' Som, 2005"" />")
                sb.Append("<add key=""Revisión"" value=""Tue, 15 Nov 2005 23:11:00 GMT"" />")
                sb.Append("<!-- La clase siempre los añade como un elemento -->")
                sb.Append("<Copyright>©Guillermo 'guille' Som, 2005</Copyright>")
                sb.Append("</General>")
                sb.Append("</configuration>")
                ' Asignamos la cadena al objeto
                configXml.LoadXml(sb.ToString)
                '
                ' Guardamos el contenido de configXml y creamos el fichero
                configXml.Save(ficConfig)
            End If
        End Sub

        Public Property FileName() As String
            Get
                Return ficConfig
            End Get
            Set(ByVal value As String)
                ' Al asignarlo, NO leemos el contenido del fichero
                ficConfig = value
                'LeerFile()
            End Set
        End Property

        'Public Sub New()
        '    ' Asignamos automáticamente el nombre del fichero, y lo leemos
        '    ' Este constructor no deberíamos usarlo si esta clase está en una DLL
        '    ficConfig = System.Reflection.Assembly.GetExecutingAssembly.Location & ".cfg"
        '    Read()
        'End Sub
        Public Sub New(ByVal fic As String)
            ficConfig = fic
            Read()
        End Sub
        '
        '----------------------------------------------------------------------
        ' Los métodos privados
        '----------------------------------------------------------------------
        '
        ' El método interno para guardar los valores
        ' Este método siempre guardará en el formato <seccion><clave>valor</clave></seccion>
        Private Sub cfgSetValue( _
                        ByVal seccion As String, _
                        ByVal clave As String, _
                        ByVal valor As String)
            '
            Dim n As XmlNode
            '
            ' Se comrpueba si es un elemento de la sección:
            '   <seccion><clave>valor</clave></seccion>
            n = configXml.SelectSingleNode(configuration & seccion & "/" & clave)
            If Not n Is Nothing Then
                n.InnerText = valor
            Else
                Dim root As XmlNode
                Dim elem As XmlElement
                root = configXml.SelectSingleNode(configuration & seccion)
                If root Is Nothing Then
                    ' Si no existe el elemento principal,
                    ' lo añadimos a <configuration>
                    elem = configXml.CreateElement(seccion)
                    configXml.DocumentElement.AppendChild(elem)
                    root = configXml.SelectSingleNode(configuration & seccion)
                End If
                If Not root Is Nothing Then
                    ' Crear el elemento
                    elem = configXml.CreateElement(clave)
                    elem.InnerText = valor
                    ' Añadirlo al nodo indicado
                    root.AppendChild(elem)
                End If
            End If
            '
            '------------------------------------------------------------------
            ' Para guardar en el formato de appSettings, usar: SetKeyValue
            '------------------------------------------------------------------
            '
            '' Primero comprobamos si estamos asignando al estilo de appSettings: <add key=clave value=valor />
            'n = configXml.SelectSingleNode(configuration & seccion & "/add[@key=""" & clave & """]")
            'If Not n Is Nothing Then
            '    n.Attributes("value").InnerText = valor
            'Else
            '    ' Por último si es un elemento de la sección:
            '    '   <seccion><clave>valor</clave></seccion>
            '    n = configXml.SelectSingleNode(configuration & seccion & "/" & clave)
            '    If Not n Is Nothing Then
            '        n.InnerText = valor
            '    Else
            '        Dim root As XmlNode
            '        Dim elem As XmlElement
            '        root = configXml.SelectSingleNode(configuration & seccion)
            '        If root Is Nothing Then
            '            ' Si no existe el elemento principal,
            '            ' lo añadimos a <configuration>
            '            elem = configXml.CreateElement(seccion)
            '            configXml.DocumentElement.AppendChild(elem)
            '            root = configXml.SelectSingleNode(configuration & seccion)
            '        End If
            '        If Not root Is Nothing Then
            '            ' Crear el elemento
            '            elem = configXml.CreateElement(clave)
            '            elem.InnerText = valor
            '            ' Añadirlo al nodo indicado
            '            root.AppendChild(elem)
            '        End If
            '    End If
            'End If
        End Sub

        ' Asigna un atributo a una sección
        ' Por ejemplo: <Seccion clave=valor>...</Seccion>
        ' También se usará para el formato de appSettings: <add key=clave value=valor />
        '   Aunque en este caso, debe existir el elemento a asignar.
        Private Sub cfgSetKeyValue( _
                        ByVal seccion As String, _
                        ByVal clave As String, _
                        ByVal valor As String)
            '
            Dim n As XmlNode
            '
            n = configXml.SelectSingleNode(configuration & seccion & "/add[@key=""" & clave & """]")
            If Not n Is Nothing Then
                n.Attributes("value").InnerText = valor
            Else
                Dim root As XmlNode
                Dim elem As XmlElement
                root = configXml.SelectSingleNode(configuration & seccion)
                If root Is Nothing Then
                    ' Si no existe el elemento principal,
                    ' lo añadimos a <configuration>
                    elem = configXml.CreateElement(seccion)
                    configXml.DocumentElement.AppendChild(elem)
                    root = configXml.SelectSingleNode(configuration & seccion)
                End If
                If Not root Is Nothing Then
                    Dim a As XmlAttribute = CType(configXml.CreateNode(XmlNodeType.Attribute, clave, Nothing), XmlAttribute)
                    a.InnerText = valor
                    root.Attributes.Append(a)
                End If
            End If
        End Sub

        ' Devolver el valor de la clave indicada
        Private Function cfgGetValue( _
                        ByVal seccion As String, _
                        ByVal clave As String, _
                        ByVal valor As String _
                        ) As String
            '
            Dim n As XmlNode
            '
            ' Primero comprobar si están el formato de appSettings: <add key = clave value = valor />
            n = configXml.SelectSingleNode(configuration & seccion & "/add[@key=""" & clave & """]")
            If Not n Is Nothing Then
                Return n.Attributes("value").InnerText
            End If
            '
            ' Después se comprueba si está en el formato <Seccion clave = valor>
            n = configXml.SelectSingleNode(configuration & seccion)
            If Not n Is Nothing Then
                Dim a As XmlAttribute = n.Attributes(clave)
                If Not a Is Nothing Then
                    Return a.InnerText
                End If
            End If
            '
            ' Por último se comprueba si es un elemento de seccion:
            '   <seccion><clave>valor</clave></seccion>
            n = configXml.SelectSingleNode(configuration & seccion & "/" & clave)
            If Not n Is Nothing Then
                Return n.InnerText
            End If
            '
            ' Si no existe, se devuelve el valor predeterminado
            Return valor
        End Function
    End Class
End Namespace
