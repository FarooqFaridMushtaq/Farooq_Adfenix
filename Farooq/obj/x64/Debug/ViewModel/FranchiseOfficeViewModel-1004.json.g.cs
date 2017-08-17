// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModel\FranchiseOfficeViewModel.json"
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
using __FrHtml__ = global::Farooq.ViewModel.FranchiseOfficeViewModel.Input.Html;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __FrDetailID__ = global::Farooq.ViewModel.FranchiseOfficeViewModel.Input.DetailID;
using __FrTrend__ = global::Farooq.ViewModel.FranchiseOfficeViewModel.Input.Trend;
using __FrAverageC__ = global::Farooq.ViewModel.FranchiseOfficeViewModel.Input.AverageCommission;
using __FrTotalCom__ = global::Farooq.ViewModel.FranchiseOfficeViewModel.Input.TotalCommission;
using __FrTotalSol__ = global::Farooq.ViewModel.FranchiseOfficeViewModel.Input.TotalSoldHomes;
using __FrName__ = global::Farooq.ViewModel.FranchiseOfficeViewModel.Input.Name;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Franchis1__ = global::Farooq.ViewModel.FranchiseOfficeViewModel.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __FrSchema__ = global::Farooq.ViewModel.FranchiseOfficeViewModel.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Franchis__ = global::Farooq.ViewModel.FranchiseOfficeViewModel;
using __Franchis2__ = global::Farooq.ViewModel.FranchiseOfficeViewModel.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseOfficeViewModel_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class FranchiseOfficeViewModel : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseOfficeViewModel() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseOfficeViewModel(__FrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FrSchema__ Template { get { return (__FrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Franchis__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Views/FranchiseOfficeView.html";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                TotalSoldHomes = Add<__TLong__>("TotalSoldHomes");
                TotalSoldHomes.DefaultValue = 0L;
                TotalSoldHomes.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__TotalSoldHomes__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__TotalSoldHomes__ = (System.Int64)_v_; }, false);
                TotalCommission = Add<__TLong__>("TotalCommission");
                TotalCommission.DefaultValue = 0L;
                TotalCommission.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__TotalCommission__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__TotalCommission__ = (System.Int64)_v_; }, false);
                AverageCommission = Add<__TLong__>("AverageCommission");
                AverageCommission.DefaultValue = 0L;
                AverageCommission.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__AverageCommission__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__AverageCommission__ = (System.Int64)_v_; }, false);
                Trend = Add<__TLong__>("Trend");
                Trend.DefaultValue = 0L;
                Trend.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Trend__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Trend__ = (System.Int64)_v_; }, false);
                DetailID = Add<__TString__>("DetailID");
                DetailID.DefaultValue = "";
                DetailID.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__DetailID__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__DetailID__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TLong__ TotalSoldHomes;
            public __TLong__ TotalCommission;
            public __TLong__ AverageCommission;
            public __TLong__ Trend;
            public __TString__ DetailID;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModel\FranchiseOfficeViewModel.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModel\FranchiseOfficeViewModel.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "ViewModel\FranchiseOfficeViewModel.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "ViewModel\FranchiseOfficeViewModel.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TotalSoldHomes__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TotalSoldHomes {
    #line 4 "ViewModel\FranchiseOfficeViewModel.json"
        get {
        #line hidden
            return Template.TotalSoldHomes.Getter(this); }
        #line 4 "ViewModel\FranchiseOfficeViewModel.json"
        set {
        #line hidden
            Template.TotalSoldHomes.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TotalCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TotalCommission {
    #line 5 "ViewModel\FranchiseOfficeViewModel.json"
        get {
        #line hidden
            return Template.TotalCommission.Getter(this); }
        #line 5 "ViewModel\FranchiseOfficeViewModel.json"
        set {
        #line hidden
            Template.TotalCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AverageCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AverageCommission {
    #line 6 "ViewModel\FranchiseOfficeViewModel.json"
        get {
        #line hidden
            return Template.AverageCommission.Getter(this); }
        #line 6 "ViewModel\FranchiseOfficeViewModel.json"
        set {
        #line hidden
            Template.AverageCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Trend__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Trend {
    #line 7 "ViewModel\FranchiseOfficeViewModel.json"
        get {
        #line hidden
            return Template.Trend.Getter(this); }
        #line 7 "ViewModel\FranchiseOfficeViewModel.json"
        set {
        #line hidden
            Template.Trend.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__DetailID__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String DetailID {
    #line 8 "ViewModel\FranchiseOfficeViewModel.json"
        get {
        #line hidden
            return Template.DetailID.Getter(this); }
        #line 8 "ViewModel\FranchiseOfficeViewModel.json"
        set {
        #line hidden
            Template.DetailID.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class TotalSoldHomes : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class TotalCommission : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AverageCommission : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Trend : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class DetailID : Input<__Franchis__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
