<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EmpSkillData.aspx.cs" Inherits="Admin_CRUD_EmpSkillData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="jumbotron">
        <h1>Skills</h1>    
        <p>Employee skill data related to a supplied skill</p>   
    </div>


     <div class="row">
        <div class="col-md-8">

            <asp:Label ID="Skill" runat="server" Text="Select a SKill"></asp:Label>
            <asp:DropDownList ID="skillDropDownList" runat="server" DataSourceID="SKillObjectDataSource" DataTextField="Description"
                 DataValueField="SkillID"               
                >
                 <asp:ListItem Value="0">select ...</asp:ListItem>
            </asp:DropDownList>
            <asp:ObjectDataSource runat="server" ID="SKillObjectDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAllSkills" TypeName="WorkSchedule.System.BLL.SkillsController"></asp:ObjectDataSource>

            <asp:LinkButton runat="server">Search</asp:LinkButton>
           
            <br><br><br>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" 
                 CellPadding="4" ForeColor="#222222" GridLines="Both" AllowPaging="true" PageSize ="5" SortedDescendingHeaderStyle-HorizontalAlign="Center">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone"></asp:BoundField>
                    <asp:CheckBoxField DataField="Active" HeaderText="Active" SortExpression="Active"></asp:CheckBoxField>
                    <asp:BoundField DataField="SkillLevel" HeaderText="SkillLevel" SortExpression="SkillLevel"></asp:BoundField>
                    <asp:BoundField DataField="YOE" HeaderText="YOE" SortExpression="YOE"></asp:BoundField>
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" OldValuesParameterFormatString="original_{0}" SelectMethod="EmployeeSkillReport_Get" TypeName="WorkSchedule.System.BLL.EmployeeSkillsController">
                <SelectParameters>
                    <asp:ControlParameter  ControlID="skillDropDownList" PropertyName="SelectedValue" Name="value" Type="Int32"/>
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
     </div>
</asp:Content>

