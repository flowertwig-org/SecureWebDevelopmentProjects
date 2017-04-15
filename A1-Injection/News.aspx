<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="A1_Injection.Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Nyheter</h1>
            <div>
                <select class="news-filter" id="filter" runat="server">
                    <option value="1">Alla</option>
                    <option value="2">Viktigt</option>
                    <option value="3">Information</option>
                    <option value="4">Övrigt</option>
                </select>
            </div>

            <asp:Label runat="server" ID="label"></asp:Label>

        </div>
        <script>
            var filter = document.querySelector('.news-filter');
            filter.addEventListener('change',
                function (e) {
                    window.location.search = 'tag=' + this.value;
                });

            var tag = window.location.search.replace('?tag=', '');
            if (tag) {
                filter.value = tag;
            }
        </script>
    </form>
</body>
</html>
