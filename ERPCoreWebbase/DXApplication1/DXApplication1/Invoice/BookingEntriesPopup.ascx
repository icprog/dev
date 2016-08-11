﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BookingEntriesPopup.ascx.cs"
    Inherits="WebModule.Invoice.BookingEntriesPopup" %>
<%@ Register Src="../Accounting/Journal/Transaction/Control/GridViewBookingEntries.ascx"
    TagName="GridViewBookingEntries" TagPrefix="uc1" %>
<script type="text/javascript">

    var BookingEntriesFormClass = function () {
        this.Closing = new NASClientEvent();

        this.RaiseClosing = function () {
            this.Closing.FireEvent(this, null);
        };

        this.Show = function(billId)
        {
            if(billId)
            {
                if(!panelBookingEntriesPopup.InCallback()) 
                {
                    var args = 'Show|' + billId;
                    panelBookingEntriesPopup.PerformCallback(args);
                }
            }
            else
            {
                throw 'BillId cannot be null';
            }
        };

        this.Cancel = function()
        {
            if(!panelBookingEntriesPopup.InCallback()) 
            {
                var args = 'Cancel';
                panelBookingEntriesPopup.PerformCallback(args);
            }
        };

        this.Book = function()
        {
            if(!panelBookingEntriesPopup.InCallback()) 
            {
                var args = 'Book';
                panelBookingEntriesPopup.PerformCallback(args);
            }
        }
    };

    var nasObj = new BookingEntriesFormClass();
    window['<%= _ClientInstanceName %>'] = nasObj;
    
    <% if(Closing != null && Closing.Trim().Length > 0) { %>
        nasObj.Closing.AddHandler(<%= Closing %>);
    <% } %>

    function btnBookEntries_Click(s, e)
    {
        window['<%= _ClientInstanceName %>'].Book();
    }

    function btnCancel_Click(s, e)
    {
        window['<%= _ClientInstanceName %>'].Cancel();
    }

    function panelBookingEntriesPopup_EndCallback(s, e)
    {
        if(s.cpEvent == 'Closing')
        {
            window['<%= _ClientInstanceName %>'].RaiseClosing();
            delete s.cpEvent;
        }
        if(s.cpError)
        {
            alert(s.cpError);
            delete s.cpError;
        }
    }

</script>
<dx:ASPxCallbackPanel ID="panelBookingEntriesPopup" ClientInstanceName="panelBookingEntriesPopup"
    runat="server" Width="100%" OnCallback="panelBookingEntriesPopup_Callback">
    <ClientSideEvents EndCallback="panelBookingEntriesPopup_EndCallback" />
    <PanelCollection>
        <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
            <dx:ASPxPopupControl ID="popupBookingEntriesForm" runat="server" Maximized="True"
                RenderMode="Lightweight" ShowMaximizeButton="True" AllowDragging="True" AllowResize="True"
                AutoUpdatePosition="True" CloseAction="CloseButton" Height="420px" Modal="True"
                PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="True"
                Width="860px">
                <FooterTemplate>
                    <div style="padding: 10px;">
                        <div style="float: left">
                            <div style="float: left">
                                <!-- Places button here -->
                                <dx:ASPxButton ID="btnHelp" CausesValidation="false" UseSubmitBehavior="false" runat="server"
                                    Text="Trợ giúp" AutoPostBack="false">
                                    <Image ToolTip="Trợ giúp">
                                        <SpriteProperties CssClass="Sprite_Help" />
                                    </Image>
                                </dx:ASPxButton>
                            </div>
                            <div style="float: left; margin-left: 4px">
                                <!-- Places button here -->
                            </div>
                        </div>
                        <div style="float: right">
                            <div style="float: left; margin-left: 4px">
                                <!-- Places button here -->
                                <dx:ASPxButton ID="btnBookEntries" CausesValidation="false" UseSubmitBehavior="false"
                                    runat="server" Text="Ghi sổ" AutoPostBack="false">
                                    <ClientSideEvents Click="btnBookEntries_Click" />
                                    <Image ToolTip="Hạch toán">
                                        <SpriteProperties CssClass="Sprite_Approve" />
                                    </Image>
                                </dx:ASPxButton>
                            </div>
                            <div style="float: left; margin-left: 4px">
                                <!-- Places button here -->
                                <dx:ASPxButton ID="btnCancel" CausesValidation="false" UseSubmitBehavior="false"
                                    runat="server" Text="Thoát" AutoPostBack="false">
                                    <ClientSideEvents Click="btnCancel_Click" />
                                    <Image ToolTip="Thoát">
                                        <SpriteProperties CssClass="Sprite_Cancel" />
                                    </Image>
                                </dx:ASPxButton>
                            </div>
                        </div>
                        <div style="clear: both">
                        </div>
                    </div>
                </FooterTemplate>
                <ContentCollection>
                    <dx:PopupControlContentControl runat="server" SupportsDisabledAttribute="True">
                        <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" Width="100%">
                            <Items>
                                <dx:LayoutGroup Caption="Thông tin phiếu mua hàng" ColCount="3">
                                    <Items>
                                        <dx:LayoutItem Caption="Số phiếu mua">
                                            <LayoutItemNestedControlCollection>
                                                <dx:LayoutItemNestedControlContainer runat="server" 
                                                    SupportsDisabledAttribute="True">
                                                    <dx:ASPxLabel ID="lblCode" runat="server" Font-Bold="True">
                                                    </dx:ASPxLabel>
                                                </dx:LayoutItemNestedControlContainer>
                                            </LayoutItemNestedControlCollection>
                                        </dx:LayoutItem>
                                        <dx:LayoutItem Caption="Ngày">
                                            <LayoutItemNestedControlCollection>
                                                <dx:LayoutItemNestedControlContainer runat="server" 
                                                    SupportsDisabledAttribute="True">
                                                    <dx:ASPxLabel ID="lblIssuedDate" runat="server" Font-Bold="True">
                                                    </dx:ASPxLabel>
                                                </dx:LayoutItemNestedControlContainer>
                                            </LayoutItemNestedControlCollection>
                                        </dx:LayoutItem>
                                        <dx:LayoutItem Caption="Nhà cung cấp">
                                            <LayoutItemNestedControlCollection>
                                                <dx:LayoutItemNestedControlContainer runat="server" 
                                                    SupportsDisabledAttribute="True">
                                                    <dx:ASPxLabel ID="lblOrganization" runat="server" Font-Bold="True">
                                                    </dx:ASPxLabel>
                                                </dx:LayoutItemNestedControlContainer>
                                            </LayoutItemNestedControlCollection>
                                        </dx:LayoutItem>
                                        <dx:LayoutItem Caption="Tổng tiền hàng">
                                            <LayoutItemNestedControlCollection>
                                                <dx:LayoutItemNestedControlContainer runat="server" 
                                                    SupportsDisabledAttribute="True">
                                                    <dx:ASPxLabel ID="lblSumOfTotalPrice" runat="server" Font-Bold="True">
                                                    </dx:ASPxLabel>
                                                </dx:LayoutItemNestedControlContainer>
                                            </LayoutItemNestedControlCollection>
                                        </dx:LayoutItem>
                                        <dx:LayoutItem Caption="Tiền chiết khấu">
                                            <LayoutItemNestedControlCollection>
                                                <dx:LayoutItemNestedControlContainer runat="server" 
                                                    SupportsDisabledAttribute="True">
                                                    <dx:ASPxLabel ID="lblSumOfPromotion" runat="server" Font-Bold="True">
                                                    </dx:ASPxLabel>
                                                </dx:LayoutItemNestedControlContainer>
                                            </LayoutItemNestedControlCollection>
                                        </dx:LayoutItem>
                                        <dx:LayoutItem Caption="Tiền thuế">
                                            <LayoutItemNestedControlCollection>
                                                <dx:LayoutItemNestedControlContainer runat="server" 
                                                    SupportsDisabledAttribute="True">
                                                    <dx:ASPxLabel ID="lblSumOfTax" runat="server" Font-Bold="True">
                                                    </dx:ASPxLabel>
                                                </dx:LayoutItemNestedControlContainer>
                                            </LayoutItemNestedControlCollection>
                                        </dx:LayoutItem>
                                        <dx:LayoutItem Caption="Tổng cộng">
                                            <LayoutItemNestedControlCollection>
                                                <dx:LayoutItemNestedControlContainer runat="server" 
                                                    SupportsDisabledAttribute="True">
                                                    <dx:ASPxLabel ID="lblTotal" runat="server" Font-Bold="True">
                                                    </dx:ASPxLabel>
                                                </dx:LayoutItemNestedControlContainer>
                                            </LayoutItemNestedControlCollection>
                                        </dx:LayoutItem>
                                        <dx:LayoutItem Caption="Trạng thái">
                                            <LayoutItemNestedControlCollection>
                                                <dx:LayoutItemNestedControlContainer runat="server" 
                                                    SupportsDisabledAttribute="True">
                                                    <dx:ASPxLabel ID="lblBookingStatus" runat="server" Font-Bold="True">
                                                    </dx:ASPxLabel>
                                                </dx:LayoutItemNestedControlContainer>
                                            </LayoutItemNestedControlCollection>
                                        </dx:LayoutItem>
                                    </Items>
                                </dx:LayoutGroup>
                                <dx:LayoutGroup Caption="Thông tin hạch toán">
                                    <Items>
                                        <dx:LayoutItem Caption=" " ShowCaption="False">
                                            <LayoutItemNestedControlCollection>
                                                <dx:LayoutItemNestedControlContainer runat="server" 
                                                    SupportsDisabledAttribute="True">
                                                    <uc1:GridViewBookingEntries ID="gridviewBookingEntriesForm" runat="server" 
                                                        ClientInstanceName="gridviewBookingEntriesForm" />
                                                </dx:LayoutItemNestedControlContainer>
                                            </LayoutItemNestedControlCollection>
                                        </dx:LayoutItem>
                                    </Items>
                                </dx:LayoutGroup>
                            </Items>
                        </dx:ASPxFormLayout>
                    </dx:PopupControlContentControl>
                </ContentCollection>
            </dx:ASPxPopupControl>
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
