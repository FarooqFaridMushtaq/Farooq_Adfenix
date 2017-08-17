// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModel\CorporationViewModel.json"
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
using __Corporat2__ = global::Farooq.ViewModel.CorporationViewModel.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __CoAddNewFr__ = global::Farooq.ViewModel.CorporationViewModel.Input.AddNewFranchise;
using __CoFranchis__ = global::Farooq.ViewModel.CorporationViewModel.Input.FranchiseName;
using __CoSortOnTr__ = global::Farooq.ViewModel.CorporationViewModel.Input.SortOnTrend;
using __CoSortOnAv__ = global::Farooq.ViewModel.CorporationViewModel.Input.SortOnAvgCommission;
using __CoSortOnCo__ = global::Farooq.ViewModel.CorporationViewModel.Input.SortOnCommission;
using __CoSortOnNu__ = global::Farooq.ViewModel.CorporationViewModel.Input.SortOnNumber;
using __CoName__ = global::Farooq.ViewModel.CorporationViewModel.Input.Name;
using __CoHtml__ = global::Farooq.ViewModel.CorporationViewModel.Input.Html;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __Corporat1__ = global::Farooq.ViewModel.CorporationViewModel.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __CoSchema__ = global::Farooq.ViewModel.CorporationViewModel.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Corporat__ = global::Farooq.ViewModel.CorporationViewModel;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CorporationViewModel_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class CorporationViewModel : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationViewModel() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationViewModel(__CoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CoSchema__ Template { get { return (__CoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Corporat__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Views/CorporationView.html";
                Html.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                SortOnNumber = Add<__TLong__>("SortOnNumber$");
                SortOnNumber.DefaultValue = 0L;
                SortOnNumber.Editable = true;
                SortOnNumber.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__SortOnNumber__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__SortOnNumber__ = (System.Int64)_v_; }, false);
                SortOnNumber.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortOnNumber() { App = (CorporationViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationViewModel)pup).Handle((Input.SortOnNumber)input); });
                SortOnCommission = Add<__TLong__>("SortOnCommission$");
                SortOnCommission.DefaultValue = 0L;
                SortOnCommission.Editable = true;
                SortOnCommission.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__SortOnCommission__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__SortOnCommission__ = (System.Int64)_v_; }, false);
                SortOnCommission.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortOnCommission() { App = (CorporationViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationViewModel)pup).Handle((Input.SortOnCommission)input); });
                SortOnAvgCommission = Add<__TLong__>("SortOnAvgCommission$");
                SortOnAvgCommission.DefaultValue = 0L;
                SortOnAvgCommission.Editable = true;
                SortOnAvgCommission.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__SortOnAvgCommission__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__SortOnAvgCommission__ = (System.Int64)_v_; }, false);
                SortOnAvgCommission.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortOnAvgCommission() { App = (CorporationViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationViewModel)pup).Handle((Input.SortOnAvgCommission)input); });
                SortOnTrend = Add<__TLong__>("SortOnTrend$");
                SortOnTrend.DefaultValue = 0L;
                SortOnTrend.Editable = true;
                SortOnTrend.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__SortOnTrend__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__SortOnTrend__ = (System.Int64)_v_; }, false);
                SortOnTrend.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortOnTrend() { App = (CorporationViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationViewModel)pup).Handle((Input.SortOnTrend)input); });
                FranchiseList = Add<__TArray__>("FranchiseList");
                FranchiseList.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__FranchiseList__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__FranchiseList__ = (__Arr__)_v_; }, false);
                FranchiseName = Add<__TString__>("FranchiseName$");
                FranchiseName.DefaultValue = "";
                FranchiseName.Editable = true;
                FranchiseName.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__FranchiseName__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__FranchiseName__ = (System.String)_v_; }, false);
                AddNewFranchise = Add<__TLong__>("AddNewFranchise$");
                AddNewFranchise.DefaultValue = 0L;
                AddNewFranchise.Editable = true;
                AddNewFranchise.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__AddNewFranchise__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__AddNewFranchise__ = (System.Int64)_v_; }, false);
                AddNewFranchise.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddNewFranchise() { App = (CorporationViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationViewModel)pup).Handle((Input.AddNewFranchise)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Corporat__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TLong__ SortOnNumber;
            public __TLong__ SortOnCommission;
            public __TLong__ SortOnAvgCommission;
            public __TLong__ SortOnTrend;
            public __TArray__ FranchiseList;
            public __TString__ FranchiseName;
            public __TLong__ AddNewFranchise;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModel\CorporationViewModel.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModel\CorporationViewModel.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "ViewModel\CorporationViewModel.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "ViewModel\CorporationViewModel.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortOnNumber__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortOnNumber {
    #line 4 "ViewModel\CorporationViewModel.json"
        get {
        #line hidden
            return Template.SortOnNumber.Getter(this); }
        #line 4 "ViewModel\CorporationViewModel.json"
        set {
        #line hidden
            Template.SortOnNumber.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortOnCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortOnCommission {
    #line 5 "ViewModel\CorporationViewModel.json"
        get {
        #line hidden
            return Template.SortOnCommission.Getter(this); }
        #line 5 "ViewModel\CorporationViewModel.json"
        set {
        #line hidden
            Template.SortOnCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortOnAvgCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortOnAvgCommission {
    #line 6 "ViewModel\CorporationViewModel.json"
        get {
        #line hidden
            return Template.SortOnAvgCommission.Getter(this); }
        #line 6 "ViewModel\CorporationViewModel.json"
        set {
        #line hidden
            Template.SortOnAvgCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortOnTrend__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortOnTrend {
    #line 7 "ViewModel\CorporationViewModel.json"
        get {
        #line hidden
            return Template.SortOnTrend.Getter(this); }
        #line 7 "ViewModel\CorporationViewModel.json"
        set {
        #line hidden
            Template.SortOnTrend.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__FranchiseList__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ FranchiseList {
    #line 8 "ViewModel\CorporationViewModel.json"
        get {
        #line hidden
            return Template.FranchiseList.Getter(this); }
        #line 8 "ViewModel\CorporationViewModel.json"
        set {
        #line hidden
            Template.FranchiseList.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FranchiseName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FranchiseName {
    #line 9 "ViewModel\CorporationViewModel.json"
        get {
        #line hidden
            return Template.FranchiseName.Getter(this); }
        #line 9 "ViewModel\CorporationViewModel.json"
        set {
        #line hidden
            Template.FranchiseName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddNewFranchise__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddNewFranchise {
    #line 10 "ViewModel\CorporationViewModel.json"
        get {
        #line hidden
            return Template.AddNewFranchise.Getter(this); }
        #line 10 "ViewModel\CorporationViewModel.json"
        set {
        #line hidden
            Template.AddNewFranchise.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SortOnNumber : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SortOnCommission : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SortOnAvgCommission : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SortOnTrend : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class FranchiseName : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddNewFranchise : Input<__Corporat__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
