// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModel\MainPageViewModel.json"
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
using __MainPage1__ = global::Farooq.ViewModel.MainPageViewModel.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __MaAddNewCo__ = global::Farooq.ViewModel.MainPageViewModel.Input.AddNewCorporation;
using __MaName__ = global::Farooq.ViewModel.MainPageViewModel.Input.Name;
using __MaHtml__ = global::Farooq.ViewModel.MainPageViewModel.Input.Html;
using __MainPage2__ = global::Farooq.ViewModel.MainPageViewModel.Input;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __MaSchema__ = global::Farooq.ViewModel.MainPageViewModel.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __MainPage__ = global::Farooq.ViewModel.MainPageViewModel;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class MainPageViewModel_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class MainPageViewModel : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __MaSchema__ DefaultTemplate = new __MaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MainPageViewModel() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MainPageViewModel(__MaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __MaSchema__ Template { get { return (__MaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__MainPage__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Views/MainPageView.html";
                Html.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                AddNewCorporation = Add<__TLong__>("AddNewCorporation$");
                AddNewCorporation.DefaultValue = 0L;
                AddNewCorporation.Editable = true;
                AddNewCorporation.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__AddNewCorporation__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__AddNewCorporation__ = (System.Int64)_v_; }, false);
                AddNewCorporation.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddNewCorporation() { App = (MainPageViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((MainPageViewModel)pup).Handle((Input.AddNewCorporation)input); });
                Corporations = Add<__TArray__>("Corporations");
                Corporations.SetCustomAccessors((_p_) => { return ((__MainPage__)_p_).__bf__Corporations__; }, (_p_, _v_) => { ((__MainPage__)_p_).__bf__Corporations__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __MainPage__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TLong__ AddNewCorporation;
            public __TArray__ Corporations;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModel\MainPageViewModel.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModel\MainPageViewModel.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "ViewModel\MainPageViewModel.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "ViewModel\MainPageViewModel.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddNewCorporation__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddNewCorporation {
    #line 4 "ViewModel\MainPageViewModel.json"
        get {
        #line hidden
            return Template.AddNewCorporation.Getter(this); }
        #line 4 "ViewModel\MainPageViewModel.json"
        set {
        #line hidden
            Template.AddNewCorporation.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Corporations__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Corporations {
    #line 5 "ViewModel\MainPageViewModel.json"
        get {
        #line hidden
            return Template.Corporations.Getter(this); }
        #line 5 "ViewModel\MainPageViewModel.json"
        set {
        #line hidden
            Template.Corporations.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__MainPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__MainPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddNewCorporation : Input<__MainPage__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
