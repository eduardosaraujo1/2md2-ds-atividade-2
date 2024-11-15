﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AtividadeDoisCopiaAtividade.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
        <style>
            .container {
                display: grid;
                grid-template-columns: repeat(3, 1fr);
                max-width: 80%;
                margin-left: auto;
                margin-right: auto;
            }

            .container > * {
                border: 1px dotted gray;
                padding: 0.5rem 0.25rem;
                text-align: left;
            }

            .span-100 {
                grid-column-start: 1;
                grid-column-end: -1;
            }

            .text-center {
                text-align: center;
            }

            .text-right {
                text-align: right;
            }

            .vertical-center {
                display: grid;
                align-items: center;
            }

            .list {
                display: flex;
                flex-direction: column;
                align-items: center;
                gap: 2px;
            }

            .image-button {
                min-width: 100px;
            }

            .image-display {
                min-height: 3rem;
            }

            .font-large {
                font-size: 1.5rem;
            }
        </style>
    </head>
    <body>
        <form id="form1" runat="server">
            <div class="container text-center">
                <div class="span-100">
                    <h1 class="">Trabalhando com LinkButton, CheckBox, RadioButton, Image e ImageButton</h1>
                </div>
                <asp:Label ID="lblErro" runat="server" CssClass="span-100"></asp:Label>
                <span class="text-right vertical-center">Digite um texto: </span>
                <div class="input vertical-center">
                    <asp:TextBox ID="text" runat="server"></asp:TextBox>
                </div>
                <div class="list">
                    <asp:ImageButton ID="btnSelecionar" runat="server" ImageUrl="~/Imagens/imgbtnselecionar.png" CssClass="image-button" OnClick="btnSelecionar_Click" />
                    <asp:ImageButton ID="btnLimpar" runat="server" ImageUrl="~/Imagens/imgbtnlimpar.png" CssClass="image-button" OnClick="btnLimpar_Click" />
                </div>
                <div class="text-right vertical-center">Formatação da fonte:</div>
                <div>
                    <asp:RadioButton ID="radioNegrito" runat="server" GroupName="tamanho" Text="Negrito" AutoPostBack="True" OnCheckedChanged="refreshFontAndImage" />
                    <br />
                    <asp:RadioButton ID="radioSublinhado" runat="server" GroupName="tamanho" Text="Sublinhado" AutoPostBack="True" OnCheckedChanged="refreshFontAndImage" />
                </div>
                <div>
                    <asp:RadioButton ID="radioItalico" runat="server" GroupName="tamanho" Text="Itálico" AutoPostBack="True" OnCheckedChanged="refreshFontAndImage" />
                    <br />
                    <asp:RadioButton ID="radioReset" runat="server" GroupName="tamanho" Text="Limpar Formatação" AutoPostBack="True" OnCheckedChanged="refreshFontAndImage" Checked="True" />
                </div>
                <asp:Label ID="lblVisor" runat="server" CssClass="span-100 font-large text-center"></asp:Label>
                <div class="span-100 text-center">
                    <asp:Image ID="imgFormat" runat="server" CssClass="image-display" />
                </div>
            </div>
        </form>
    </body>
</html>
