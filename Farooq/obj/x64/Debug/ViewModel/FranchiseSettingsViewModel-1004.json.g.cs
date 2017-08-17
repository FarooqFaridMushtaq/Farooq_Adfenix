// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModel\FranchiseSettingsViewModel.json"
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
using Starcounter.Binding;
#pragma warning disable 0108
#pragma warning disable 1591

namespace Farooq.ViewModel {
using __FrCity__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.City;
using __FrFullAddr__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.FullAddress;
using __FrSaveFran__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.SaveFranchiseSettings;
using __FrHomeStre__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.HomeStreet;
using __FrHomeNumb__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.HomeNumber;
using __FrHomeZipC__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.HomeZipCode;
using __FrHomeCity__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.HomeCity;
using __FrHomeCoun__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.HomeCountry;
using __FrHomeFull__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.HomeFullAddress;
using __FrDate__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.Date;
using __FrSalesPri__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.SalesPrice;
using __FrCommissi__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.Commission;
using __FrRegister__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.RegisterTransaction;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __FrCountry__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.Country;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __FrNumber__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.Number;
using __Franchis__ = global::Farooq.ViewModel.FranchiseSettingsViewModel;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __FrSchema__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __FrZipCode__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.ZipCode;
using __TLong__ = global::Starcounter.Templates.TLong;
using __Franchis1__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.JsonByExample;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __Franchis2__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input;
using __FrHtml__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.Html;
using __FrName__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.Name;
using __FrStreet__ = global::Farooq.ViewModel.FranchiseSettingsViewModel.Input.Street;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseSettingsViewModel_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class FranchiseSettingsViewModel : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseSettingsViewModel() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseSettingsViewModel(__FrSchema__ template) { Template = template; }
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
                Html.DefaultValue = "/Views/FranchiseSettingsView.html";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Street = Add<__TString__>("Street$");
                Street.DefaultValue = "";
                Street.Editable = true;
                Street.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                Number = Add<__TString__>("Number$");
                Number.DefaultValue = "";
                Number.Editable = true;
                Number.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Number__ = (System.String)_v_; }, false);
                ZipCode = Add<__TString__>("ZipCode$");
                ZipCode.DefaultValue = "";
                ZipCode.Editable = true;
                ZipCode.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__ZipCode__ = (System.String)_v_; }, false);
                City = Add<__TString__>("City$");
                City.DefaultValue = "";
                City.Editable = true;
                City.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__City__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__City__ = (System.String)_v_; }, false);
                Country = Add<__TString__>("Country$");
                Country.DefaultValue = "";
                Country.Editable = true;
                Country.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                FullAddress = Add<__TString__>("FullAddress", bind:"FullAddress");
                FullAddress.DefaultValue = "";
                FullAddress.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__FullAddress__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__FullAddress__ = (System.String)_v_; }, false);
                SaveFranchiseSettings = Add<__TLong__>("SaveFranchiseSettings$");
                SaveFranchiseSettings.DefaultValue = 0L;
                SaveFranchiseSettings.Editable = true;
                SaveFranchiseSettings.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SaveFranchiseSettings__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SaveFranchiseSettings__ = (System.Int64)_v_; }, false);
                SaveFranchiseSettings.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveFranchiseSettings() { App = (FranchiseSettingsViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseSettingsViewModel)pup).Handle((Input.SaveFranchiseSettings)input); });
                HomeStreet = Add<__TString__>("HomeStreet$");
                HomeStreet.DefaultValue = "";
                HomeStreet.Editable = true;
                HomeStreet.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__HomeStreet__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__HomeStreet__ = (System.String)_v_; }, false);
                HomeStreet.AddHandler((Json pup, Property<String> prop, String value) => { return (new Input.HomeStreet() { App = (FranchiseSettingsViewModel)pup, Template = (TString)prop, Value = value }); }, (Json pup, Starcounter.Input<String> input) => { ((FranchiseSettingsViewModel)pup).Handle((Input.HomeStreet)input); });
                HomeNumber = Add<__TString__>("HomeNumber$");
                HomeNumber.DefaultValue = "";
                HomeNumber.Editable = true;
                HomeNumber.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__HomeNumber__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__HomeNumber__ = (System.String)_v_; }, false);
                HomeNumber.AddHandler((Json pup, Property<String> prop, String value) => { return (new Input.HomeNumber() { App = (FranchiseSettingsViewModel)pup, Template = (TString)prop, Value = value }); }, (Json pup, Starcounter.Input<String> input) => { ((FranchiseSettingsViewModel)pup).Handle((Input.HomeNumber)input); });
                HomeZipCode = Add<__TString__>("HomeZipCode$");
                HomeZipCode.DefaultValue = "";
                HomeZipCode.Editable = true;
                HomeZipCode.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__HomeZipCode__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__HomeZipCode__ = (System.String)_v_; }, false);
                HomeZipCode.AddHandler((Json pup, Property<String> prop, String value) => { return (new Input.HomeZipCode() { App = (FranchiseSettingsViewModel)pup, Template = (TString)prop, Value = value }); }, (Json pup, Starcounter.Input<String> input) => { ((FranchiseSettingsViewModel)pup).Handle((Input.HomeZipCode)input); });
                HomeCity = Add<__TString__>("HomeCity$");
                HomeCity.DefaultValue = "";
                HomeCity.Editable = true;
                HomeCity.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__HomeCity__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__HomeCity__ = (System.String)_v_; }, false);
                HomeCity.AddHandler((Json pup, Property<String> prop, String value) => { return (new Input.HomeCity() { App = (FranchiseSettingsViewModel)pup, Template = (TString)prop, Value = value }); }, (Json pup, Starcounter.Input<String> input) => { ((FranchiseSettingsViewModel)pup).Handle((Input.HomeCity)input); });
                HomeCountry = Add<__TString__>("HomeCountry$");
                HomeCountry.DefaultValue = "";
                HomeCountry.Editable = true;
                HomeCountry.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__HomeCountry__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__HomeCountry__ = (System.String)_v_; }, false);
                HomeCountry.AddHandler((Json pup, Property<String> prop, String value) => { return (new Input.HomeCountry() { App = (FranchiseSettingsViewModel)pup, Template = (TString)prop, Value = value }); }, (Json pup, Starcounter.Input<String> input) => { ((FranchiseSettingsViewModel)pup).Handle((Input.HomeCountry)input); });
                HomeFullAddress = Add<__TString__>("HomeFullAddress");
                HomeFullAddress.DefaultValue = "";
                HomeFullAddress.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__HomeFullAddress__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__HomeFullAddress__ = (System.String)_v_; }, false);
                Date = Add<__TString__>("Date$");
                Date.DefaultValue = "";
                Date.Editable = true;
                Date.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Date__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Date__ = (System.String)_v_; }, false);
                SalesPrice = Add<__TLong__>("SalesPrice$");
                SalesPrice.DefaultValue = 0L;
                SalesPrice.Editable = true;
                SalesPrice.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SalesPrice__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SalesPrice__ = (System.Int64)_v_; }, false);
                Commission = Add<__TLong__>("Commission$");
                Commission.DefaultValue = 0L;
                Commission.Editable = true;
                Commission.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Commission__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Commission__ = (System.Int64)_v_; }, false);
                RegisterTransaction = Add<__TLong__>("RegisterTransaction$");
                RegisterTransaction.DefaultValue = 0L;
                RegisterTransaction.Editable = true;
                RegisterTransaction.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__RegisterTransaction__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__RegisterTransaction__ = (System.Int64)_v_; }, false);
                RegisterTransaction.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.RegisterTransaction() { App = (FranchiseSettingsViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseSettingsViewModel)pup).Handle((Input.RegisterTransaction)input); });
                TransactionsList = Add<__TArray__>("TransactionsList");
                TransactionsList.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__TransactionsList__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__TransactionsList__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TString__ Street;
            public __TString__ Number;
            public __TString__ ZipCode;
            public __TString__ City;
            public __TString__ Country;
            public __TString__ FullAddress;
            public __TLong__ SaveFranchiseSettings;
            public __TString__ HomeStreet;
            public __TString__ HomeNumber;
            public __TString__ HomeZipCode;
            public __TString__ HomeCity;
            public __TString__ HomeCountry;
            public __TString__ HomeFullAddress;
            public __TString__ Date;
            public __TLong__ SalesPrice;
            public __TLong__ Commission;
            public __TLong__ RegisterTransaction;
            public __TArray__ TransactionsList;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Street__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Street {
    #line 4 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.Street.Getter(this); }
        #line 4 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.Street.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Number__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Number {
    #line 5 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.Number.Getter(this); }
        #line 5 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.Number.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__ZipCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ZipCode {
    #line 6 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.ZipCode.Getter(this); }
        #line 6 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.ZipCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__City__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String City {
    #line 7 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.City.Getter(this); }
        #line 7 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.City.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Country__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Country {
    #line 8 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.Country.Getter(this); }
        #line 8 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.Country.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FullAddress__;
    #line default
    #line hidden
    private System.Int64 __bf__SaveFranchiseSettings__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveFranchiseSettings {
    #line 10 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.SaveFranchiseSettings.Getter(this); }
        #line 10 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.SaveFranchiseSettings.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__HomeStreet__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HomeStreet {
    #line 11 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.HomeStreet.Getter(this); }
        #line 11 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.HomeStreet.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__HomeNumber__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HomeNumber {
    #line 12 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.HomeNumber.Getter(this); }
        #line 12 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.HomeNumber.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__HomeZipCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HomeZipCode {
    #line 13 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.HomeZipCode.Getter(this); }
        #line 13 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.HomeZipCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__HomeCity__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HomeCity {
    #line 14 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.HomeCity.Getter(this); }
        #line 14 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.HomeCity.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__HomeCountry__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HomeCountry {
    #line 15 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.HomeCountry.Getter(this); }
        #line 15 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.HomeCountry.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__HomeFullAddress__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HomeFullAddress {
    #line 16 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.HomeFullAddress.Getter(this); }
        #line 16 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.HomeFullAddress.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Date__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Date {
    #line 17 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.Date.Getter(this); }
        #line 17 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.Date.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SalesPrice__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SalesPrice {
    #line 18 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.SalesPrice.Getter(this); }
        #line 18 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.SalesPrice.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Commission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Commission {
    #line 19 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.Commission.Getter(this); }
        #line 19 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.Commission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__RegisterTransaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 RegisterTransaction {
    #line 20 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.RegisterTransaction.Getter(this); }
        #line 20 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.RegisterTransaction.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__TransactionsList__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ TransactionsList {
    #line 21 "ViewModel\FranchiseSettingsViewModel.json"
        get {
        #line hidden
            return Template.TransactionsList.Getter(this); }
        #line 21 "ViewModel\FranchiseSettingsViewModel.json"
        set {
        #line hidden
            Template.TransactionsList.Setter(this, value); } }
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
        public class Street : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Number : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ZipCode : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class City : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Country : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FullAddress : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveFranchiseSettings : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class HomeStreet : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HomeNumber : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HomeZipCode : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HomeCity : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HomeCountry : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HomeFullAddress : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Date : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SalesPrice : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Commission : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class RegisterTransaction : Input<__Franchis__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
