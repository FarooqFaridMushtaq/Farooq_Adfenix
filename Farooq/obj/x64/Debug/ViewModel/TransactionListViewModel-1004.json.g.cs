// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModel\TransactionListViewModel.json"
// Version: 1004
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
using Farooq.Model;
#pragma warning disable 0108
#pragma warning disable 1591

namespace Farooq.ViewModel {
using __Transact2__ = global::Farooq.ViewModel.TransactionListViewModel.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __TrHomeFull__ = global::Farooq.ViewModel.TransactionListViewModel.Input.HomeFullAddress;
using __TrCommissi__ = global::Farooq.ViewModel.TransactionListViewModel.Input.Commission;
using __TrPrice__ = global::Farooq.ViewModel.TransactionListViewModel.Input.Price;
using __TrDate__ = global::Farooq.ViewModel.TransactionListViewModel.Input.Date;
using __TrHtml__ = global::Farooq.ViewModel.TransactionListViewModel.Input.Html;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __TrSchema__ = global::Farooq.ViewModel.TransactionListViewModel.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Transact__ = global::Farooq.ViewModel.TransactionListViewModel;
using __Transact1__ = global::Farooq.ViewModel.TransactionListViewModel.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class TransactionListViewModel_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class TransactionListViewModel : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __TrSchema__ DefaultTemplate = new __TrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TransactionListViewModel() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TransactionListViewModel(__TrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __TrSchema__ Template { get { return (__TrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Transact__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Views/TransactionListView.html";
                Html.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Date = Add<__TString__>("Date");
                Date.DefaultValue = "";
                Date.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Date__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Date__ = (System.String)_v_; }, false);
                Price = Add<__TLong__>("Price");
                Price.DefaultValue = 0L;
                Price.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Price__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Price__ = (System.Int64)_v_; }, false);
                Commission = Add<__TLong__>("Commission");
                Commission.DefaultValue = 0L;
                Commission.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Commission__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Commission__ = (System.Int64)_v_; }, false);
                HomeFullAddress = Add<__TString__>("HomeFullAddress");
                HomeFullAddress.DefaultValue = "";
                HomeFullAddress.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__HomeFullAddress__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__HomeFullAddress__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Transact__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Date;
            public __TLong__ Price;
            public __TLong__ Commission;
            public __TString__ HomeFullAddress;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModel\TransactionListViewModel.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModel\TransactionListViewModel.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Date__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Date {
    #line 3 "ViewModel\TransactionListViewModel.json"
        get {
        #line hidden
            return Template.Date.Getter(this); }
        #line 3 "ViewModel\TransactionListViewModel.json"
        set {
        #line hidden
            Template.Date.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Price__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Price {
    #line 4 "ViewModel\TransactionListViewModel.json"
        get {
        #line hidden
            return Template.Price.Getter(this); }
        #line 4 "ViewModel\TransactionListViewModel.json"
        set {
        #line hidden
            Template.Price.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Commission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Commission {
    #line 5 "ViewModel\TransactionListViewModel.json"
        get {
        #line hidden
            return Template.Commission.Getter(this); }
        #line 5 "ViewModel\TransactionListViewModel.json"
        set {
        #line hidden
            Template.Commission.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__HomeFullAddress__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HomeFullAddress {
    #line 6 "ViewModel\TransactionListViewModel.json"
        get {
        #line hidden
            return Template.HomeFullAddress.Getter(this); }
        #line 6 "ViewModel\TransactionListViewModel.json"
        set {
        #line hidden
            Template.HomeFullAddress.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Transact__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Date : Input<__Transact__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Price : Input<__Transact__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Commission : Input<__Transact__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class HomeFullAddress : Input<__Transact__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
