<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="YazOkuluDersKayit.OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci ID</th>
            <th>Öğrenci Adı</th>
            <th>Öğrenci Soyadı</th>
            <th>Öğrenci Numarası</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Öğrenci Bakiye</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <%--Verileri listelemek için kullanılan yapı--%>
            <asp:Repeater ID="Repeater1" runat="server">
                <%--Veriler itemtemplate içerisine yazılacak--%>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("OgrId") %></td>
                        <td><%# Eval("OgrAd") %></td>
                        <td><%# Eval("OgrSoyad") %></td>
                        <td><%# Eval("OgrNum") %></td>
                        <td><%# Eval("OgrSifre") %></td>
                        <td><%# Eval("OgrFoto") %></td>
                        <td><%# Eval("OgrBakiye") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciSil.aspx?OgrID=" + Eval("OgrId") %>' ID="HypSil" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciGuncelle.aspx?OgrID=" + Eval("OgrId") %>' ID="HypGuncelle" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
