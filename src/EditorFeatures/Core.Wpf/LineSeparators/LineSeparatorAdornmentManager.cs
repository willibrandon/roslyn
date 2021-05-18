﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Editor.Implementation.Adornments;
using Microsoft.CodeAnalysis.Editor.Shared.Utilities;
using Microsoft.CodeAnalysis.Shared.TestHooks;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Tagging;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Editor.LineSeparators
{
    internal class LineSeparatorAdornmentManager : AdornmentManager<GraphicsTag>
    {
        public LineSeparatorAdornmentManager(IThreadingContext threadingContext, IWpfTextView textView, IViewTagAggregatorFactoryService tagAggregatorFactoryService, IAsynchronousOperationListener asyncListener, string adornmentLayerName)
            : base(threadingContext, textView, tagAggregatorFactoryService, asyncListener, adornmentLayerName)
        {
        }

        public override AdornmentManager<GraphicsTag> Create(
            IThreadingContext threadingContext,
            IWpfTextView textView,
            IViewTagAggregatorFactoryService aggregatorService,
            IAsynchronousOperationListener asyncListener,
            string adornmentLayerName)
        {
            Contract.ThrowIfNull(threadingContext);
            Contract.ThrowIfNull(textView);
            Contract.ThrowIfNull(aggregatorService);
            Contract.ThrowIfNull(adornmentLayerName);
            Contract.ThrowIfNull(asyncListener);

            return new LineSeparatorAdornmentManager(threadingContext, textView, aggregatorService, asyncListener, adornmentLayerName);
        }
    }
}
