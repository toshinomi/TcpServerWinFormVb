Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class FormMain
    Private m_thread As Thread
    Private m_tcpListener As TcpListener
    Private m_strIpAddress As String
    Private m_nPort As Integer
    Private m_bEnd As Boolean

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    ''' <summary>
    ''' デスクトラクタ
    ''' </summary>
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    ''' <summary>
    ''' 初期化
    ''' </summary>
    Public Sub Init()
        m_thread = Nothing
        m_tcpListener = Nothing
        m_strIpAddress = "127.0.0.1"
        m_nPort = 9999
        m_bEnd = False

        textBoxIpAddress.Text = m_strIpAddress
        textBoxPort.Text = m_nPort.ToString()
    End Sub

    ''' <summary>
    ''' スタートボタンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnBtnClickStart(sender As Object, e As EventArgs) Handles btnStart.Click
        m_strIpAddress = textBoxIpAddress.Text.ToString()
        m_nPort = Integer.Parse(textBoxPort.Text.ToString())

        m_thread = New Thread(AddressOf DataListener)
        m_thread.Start()
    End Sub

    ''' <summary>
    ''' データリスナー
    ''' </summary>
    Public Sub DataListener()
        Try
            m_tcpListener = New TcpListener(IPAddress.Parse(m_strIpAddress), m_nPort)
            m_tcpListener.Start()

            Invoke(New Action(Of String)(AddressOf SetTextStatus), "Server started.")

            Dim client As TcpClient = m_tcpListener.AcceptTcpClient()

            While (client.Connected = True)
                If (m_bEnd) Then
                    Exit While
                End If

                Dim networkStream As NetworkStream = client.GetStream()
                Dim aryData(4096) As Byte
                Dim nSize As Integer = networkStream.Read(aryData, 0, aryData.Length)
                Dim strGetText As String = System.Text.Encoding.Default.GetString(aryData, 0, nSize)

                Invoke(New Action(Of String)(AddressOf SetTextRcvData), strGetText)
            End While
            Invoke(New Action(Of String)(AddressOf SetTextStatus), "Server terminated.")
        Catch ex As Exception
            Dim strText As String = "Server terminated abnormally."
            If (m_bEnd) Then

                strText = "Server terminated."
            End If
            Invoke(New Action(Of String)(AddressOf SetTextStatus), strText)

            Return
        End Try
    End Sub

    ''' <summary>
    ''' ステータス表示のテキストボックス設定
    ''' </summary>
    ''' <param name="_strText">表示文字列</param>
    Public Sub SetTextStatus(_strText As String)
        textBoxStatus.Text = _strText.ToString()

        Return
    End Sub

    ''' <summary>
    ''' データ受信表示のテキストボックス設定
    ''' </summary>
    ''' <param name="_strText">表示文字列</param>
    Public Sub SetTextRcvData(_strText As String)
        textBoxRcvData.Text = _strText.ToString() + "\n"

        Return
    End Sub

    ''' <summary>
    ''' クリアボタンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnBtnClickClear(sender As Object, e As EventArgs) Handles btnClear.Click
        textBoxRcvData.Text = ""

        Return
    End Sub

    ''' <summary>
    ''' ストップボタンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Public Sub OnBtnClickStop(sender As Object, e As EventArgs) Handles btnStop.Click
        m_bEnd = True
        m_tcpListener.Stop()

        Return
    End Sub
End Class