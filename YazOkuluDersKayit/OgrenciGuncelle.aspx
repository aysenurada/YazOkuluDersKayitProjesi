﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="YazOkuluDersKayit.OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label for="TxtId" runat="server" Text="Öğrenci ID"></asp:Label>
                <asp:TextBox ID="TxtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı"></asp:Label>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı"></asp:Label>
                <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <asp:Label for="TxtNum" runat="server" Text="Öğrenci Numara"></asp:Label>
                <asp:TextBox ID="TxtNum" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <asp:Label for="TxtSifre" runat="server" Text="Öğrenci Şifre"></asp:Label>
                <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <asp:Label for="TxtFoto" runat="server" Text="Öğrenci Fotoğraf"></asp:Label>
                <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <asp:Button ID="BtnGunclle" runat="server" Text="Güncelle" CssClass="btn btn-warning" OnClick="BtnGunclle_Click" />
    </form>
</asp:Content>

