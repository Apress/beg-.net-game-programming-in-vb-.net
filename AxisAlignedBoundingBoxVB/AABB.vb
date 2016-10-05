Imports System

Public Structure AABB
    Private TopLeftX, TopLeftY As Single 'Coordinate Top Left Of The Box
    Private BottomRightX, BottomRightY As Single 'Coordinate Lower Right Of The Box
    Private BoxMinX, BoxMaxX, BoxMinY, BoxMaxY As Single

    'Constructor
    Public Sub New(ByVal TlX As Single, ByVal TlY As Single, ByVal BrX As Single, ByVal BrY As Single)
        TopLeftX = TlX
        TopLeftY = TlY
        BottomRightX = BrX
        BottomRightY = BrY
        If TopLeftX < BottomRightX Then
            BoxMinX = TopLeftX
            BoxMaxX = BottomRightX
        Else
            BoxMaxX = TopLeftX
            BoxMinX = BottomRightX
        End If
        If TopLeftY < BottomRightY Then
            BoxMinY = TopLeftY
            BoxMaxY = BottomRightY
        Else
            BoxMaxY = TopLeftY
            BoxMinY = BottomRightY
        End If
    End Sub 'New


    Public ReadOnly Property MaxX() As Single
        Get
            Return BoxMaxX
        End Get
    End Property

    Public ReadOnly Property MinX() As Single
        Get
            Return BoxMinX
        End Get
    End Property

    Public ReadOnly Property MaxY() As Single
        Get
            Return BoxMaxY
        End Get
    End Property

    Public ReadOnly Property MinY() As Single
        Get
            Return BoxMinY
        End Get
    End Property

    Public Function CircleIntersect(ByVal CircleCenterX As Single, ByVal CircleCenterY As Single, ByVal Radius As Single) As Boolean
        Dim Dist As Double = 0
        'Check X Axis. If Circle Is Outside Box Limits, Add To Distance.
        If CircleCenterX < Me.MinX Then
            Dist += Math.Pow(CircleCenterX - Me.MinX, 2.0)
        Else
            If CircleCenterX > Me.MaxX Then
                Dist += Math.Pow(CircleCenterX - Me.MaxX, 2.0)
            End If 'Check Y Axis. If Circle Is Outside Box Limits, Add To Distance.
        End If
        If CircleCenterY < Me.MinY Then
            Dist += Math.Pow(CircleCenterY - Me.MinY, 2.0)
        Else
            If CircleCenterY > Me.MaxY Then
                Dist += Math.Pow(CircleCenterY - Me.MaxY, 2.0)
            End If 'Now That Distances Along X And Y Axis Are Added, Check If The Square
        End If 'Of The Circle'S Radius Is Longer And Return The Boolean Result.
        Return Dist < Radius * Radius
    End Function 'CircleIntersect
End Structure 'AABB
