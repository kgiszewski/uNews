<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CreateNews.ascx.cs" Inherits="uNews.CreateNews" %>
<link rel="stylesheet" href='/umbraco/plugins/uNews/Create.css'/>
<script src='/umbraco/plugins/uNews/Create.js'></script>


<link rel="stylesheet" href="http://code.jquery.com/ui/1.9.2/themes/base/jquery-ui.css" />
<script src="http://code.jquery.com/jquery-1.8.3.js"></script>
<script src="http://code.jquery.com/ui/1.9.2/jquery-ui.js"></script>
 
<div id="header" class="header" runat="server">
    <div>
        <label>Title</label><input class='name' type="text" id="name" runat="server" />
    </div>

    <div>
        <label>Date</label><input class='date' type="text" id="date" readonly runat="server" />
    </div>

    <div>Select a Document Type:</div>
</div>

<div id="docTypeWrapper" class='docTypeWrapper' runat="server"></div>

<div class="footer">
    <input id="docTypeID" class="docTypeID" type="text" runat="server"/>
    <input id="createButton" class="createButton" type="button" value="Create" runat="server" />
</div>
