Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports VbBackend

Namespace Controllers
    Public Class enationdemoesController
        Inherits System.Web.Mvc.Controller

        Private db As New enationsqldbEntities

        ' GET: enationdemoes
        Function Index() As ActionResult
            Return View(db.enationdemoes.ToList())
        End Function

        ' GET: enationdemoes/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim enationdemo As enationdemo = db.enationdemoes.Find(id)
            If IsNothing(enationdemo) Then
                Return HttpNotFound()
            End If
            Return View(enationdemo)
        End Function

        ' GET: enationdemoes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: enationdemoes/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id,createdAt,updatedAt,version,deleted,Name,EmailId,Age,Gender")> ByVal enationdemo As enationdemo) As ActionResult
            If ModelState.IsValid Then
                db.enationdemoes.Add(enationdemo)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(enationdemo)
        End Function

        ' GET: enationdemoes/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim enationdemo As enationdemo = db.enationdemoes.Find(id)
            If IsNothing(enationdemo) Then
                Return HttpNotFound()
            End If
            Return View(enationdemo)
        End Function

        ' POST: enationdemoes/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id,createdAt,updatedAt,version,deleted,Name,EmailId,Age,Gender")> ByVal enationdemo As enationdemo) As ActionResult
            If ModelState.IsValid Then
                db.Entry(enationdemo).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(enationdemo)
        End Function

        ' GET: enationdemoes/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim enationdemo As enationdemo = db.enationdemoes.Find(id)
            If IsNothing(enationdemo) Then
                Return HttpNotFound()
            End If
            Return View(enationdemo)
        End Function

        ' POST: enationdemoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim enationdemo As enationdemo = db.enationdemoes.Find(id)
            db.enationdemoes.Remove(enationdemo)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
