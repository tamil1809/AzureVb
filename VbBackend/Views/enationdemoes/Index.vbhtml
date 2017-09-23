@ModelType IEnumerable(Of VbBackend.enationdemo)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.createdAt)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.updatedAt)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.version)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.deleted)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmailId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Age)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Gender)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.createdAt)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.updatedAt)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.version)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.deleted)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmailId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Age)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Gender)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id })
        </td>
    </tr>
Next

</table>
