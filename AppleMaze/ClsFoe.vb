Public Class ClsFoe
    Private strFoeTag As String
    Private strFoeTagNow As String
    Private strFoeLoc As Integer
    Private strFoeiAdd As Integer
    Private strFoeiStart As Integer
    Private strFoeMsg As String
    Private strFoePic As System.Drawing.Image
    Private strFoeiMelt As Integer
    Public Property FoeiMelt() As Integer       ' Melt time
        Get
            Return strFoeiMelt
        End Get
        Set(ByVal Value As Integer)
            strFoeiMelt = Value
        End Set
    End Property
    Public Property FoePic() As System.Drawing.Image  'Foe Image
        Get
            Return strFoePic
        End Get
        Set(ByVal Value As System.Drawing.Image)
            strFoePic = Value
        End Set
    End Property
    Public Property FoeMsg() As String      'Foe Description
        Get
            Return strFoeMsg
        End Get
        Set(ByVal Value As String)
            strFoeMsg = Value
        End Set
    End Property
    Public Property FoeiStart() As Integer      'Foe Start Loc
        Get
            Return strFoeiStart
        End Get
        Set(ByVal Value As Integer)
            strFoeiStart = Value
        End Set
    End Property
    Public Property FoeiAdd() As Integer   'Foe Dierction to go
        Get
            Return strFoeiAdd
        End Get
        Set(ByVal Value As Integer)
            strFoeiAdd = Value
        End Set
    End Property
    Public Property FoeLoc() As Integer      'Foe Location
        Get
            Return strFoeLoc
        End Get
        Set(ByVal Value As Integer)
            strFoeLoc = Value
        End Set
    End Property
    Public Property FoeTagNow() As String   'Foe Current Tag
        Get
            Return strFoeTagNow
        End Get
        Set(ByVal Value As String)
            strFoeTagNow = Value
        End Set
    End Property
    Public Property FoeTag() As String     'Foe Tag when started
        Get
            Return strFoeTag
        End Get
        Set(ByVal Value As String)
            strFoeTag = Value
        End Set
    End Property
End Class
