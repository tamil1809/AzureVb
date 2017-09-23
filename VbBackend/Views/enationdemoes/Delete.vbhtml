@ModelType VbBackend.enationdemo
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>enationdemo</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.createdAt)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.createdAt)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.updatedAt)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.updatedAt)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.version)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.version)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.deleted)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.deleted)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EmailId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EmailId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Age)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Age)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Gender)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Gender)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
