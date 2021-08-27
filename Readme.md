<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128638588/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2521)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication32/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication32/Form1.vb))
* [Program.cs](./CS/WindowsApplication32/Program.cs) (VB: [Program.vb](./VB/WindowsApplication32/Program.vb))
<!-- default file list end -->
# How to display property description via ToolTip


<p>This example demonstrates how to use the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressUtilsToolTipControllerMembersTopicAll">ToolTipController </a> class to provide custom tooltips for the PropertyGridControl.  To determine which row is being hovered with the mouse, it is necessary to use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraVerticalGridVGridControlBase_CalcHitInfotopic">VGridControlBase.CalcHitInfo</a>  method. You can get the <strong>Description</strong> of the corresponding property via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraVerticalGridPropertyGridControl_GetPropertyDescriptortopic">PropertyGridControl.GetPropertyDescriptor</a> method.</p>

<br/>


