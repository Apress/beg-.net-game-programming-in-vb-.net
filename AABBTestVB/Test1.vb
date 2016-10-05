Imports System
Imports NUnit.Framework
Imports AxisAlignedBoundingBoxVB

Namespace AABBTest
    <TestFixture()> Public Class SimpleTest
        Dim testBox1 As New AABB

        <SetUp()> _
        Public Sub Init()
            testBox1 = New AABB(2, 2, 6, 6)
        End Sub 'Init

        <Test()> _
        Public Sub OutsideCircle()
            Dim result As Boolean = testBox1.CircleIntersect(8, 8, 1)
            ' forced false result
            Assert.IsFalse(result, "Expected False.")
        End Sub 'OutsideCircle

        <Test()> _
        Public Sub InsideCircle()
            Dim result As Boolean = testBox1.CircleIntersect(3, 3, 1)
            Assert.IsTrue(result, "Expected True.")
        End Sub 'InsideCircle

        <Test()> _
        Public Sub OnCircle()
            Dim result As Boolean = testBox1.CircleIntersect(2, 2, 1)
            Assert.IsTrue(result, "Expected True.")
        End Sub 'OnCircle

        <Test()> _
        Public Sub OverlapsCircle()
            Dim result As Boolean = testBox1.CircleIntersect(7, 7, 1.5F)
            Assert.IsTrue(result, "Expected True.")
        End Sub 'OverlapsCircle
    End Class 'SimpleTest
End Namespace 'AABBTest