// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel;

using Microsoft.VisualStudio.DesignTools.Extensibility;
using Microsoft.VisualStudio.DesignTools.Extensibility.Metadata;

namespace Microsoft.Toolkit.Uwp.UI.Controls.Design
{
    internal class LoadingMetadata : AttributeTableBuilder
    {
        public LoadingMetadata()
            : base()
        {
            AddCallback(ControlTypes.Loading,
                b =>
                {
                    b.AddCustomAttributes(nameof(Loading.IsLoading), new CategoryAttribute(Resources.CategoryCommon));
                    b.AddCustomAttributes(new ToolboxCategoryAttribute(ToolboxCategoryPaths.Toolkit, false));
                }
            );
        }
    }
}