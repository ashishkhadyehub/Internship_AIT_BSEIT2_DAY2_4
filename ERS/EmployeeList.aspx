<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="EmployeeList.aspx.cs" Inherits="ERS.EmployeeList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-top: 100px">
        <h1 class="my-3" style="text-align: center">Employee List</h1>
        <div class="row">
            <div class="col-md-1">
            </div>
            <div class="col-md-10">
                <div class="table-responsive">
                    <asp:GridView runat="server" CssClass="table table-striped table-bordered" ID="gvEmployees" EmptyDataText="No employees found" >
                        <Columns>
                            <asp:TemplateField HeaderText="Details">
                                <ItemTemplate>
                                    <a class="btn btn-sm btn-outline-success" href='EmployeeProfile.aspx?id=<%# Eval("Employee_ID") %>'>Details</a>
                                </ItemTemplate>
                              
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
