// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

using Microsoft.TestPlatform.Extensions.BlameDataCollector;
using Microsoft.VisualStudio.TestPlatform;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyCopyright("� Microsoft Corporation. All rights reserved.")]
[assembly: AssemblyProduct("Microsoft.TestPlatform.Extensions.BlameDataCollector")]
[assembly: AssemblyTrademark("")]
[assembly: NeutralResourcesLanguage("en-US")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("716373d6-9162-4ac6-9ae7-b5a3a4286808")]

[assembly: TestExtensionTypes(typeof(BlameLogger), typeof(BlameCollector))]
