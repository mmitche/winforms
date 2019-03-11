// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.ComponentModel.Design
{

    using System;
    using System.Collections;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Menu command that defines text and other metadata to describe a targeted task that can be performed. 
    /// Tasks typically walk the user through some multi-step process, such as configuring a data source for a component. 
    /// Designer tasks are shown in a custom piece of UI (Chrome). 
    /// </summary>
    public abstract class DesignerActionItem
    {

        private bool allowAssociate;
        private string displayName;
        private string description;
        private string category;
        private IDictionary properties;
        private bool showInSourceView = true;


        /// <summary>
        /// To be provided.
        /// </summary>
        public DesignerActionItem(string displayName, string category, string description)
        {
            this.category = category;
            this.description = description;
            this.displayName = displayName == null ? null : Regex.Replace(displayName, @"\(\&.\)", ""); // VSWHIDBEY 485835
        }

        internal DesignerActionItem()
        {
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public bool AllowAssociate
        {
            get
            {
                return allowAssociate;
            }
            set
            {
                allowAssociate = value;
            }
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public virtual string Category => category;

        /// <summary>
        /// To be provided.
        /// </summary>
        public virtual string Description => description;

        /// <summary>
        /// To be provided.
        /// </summary>
        public virtual string DisplayName => displayName;

        /// <summary>
        /// To be provided.
        /// </summary>
        public IDictionary Properties
        {
            get
            {
                if (properties == null)
                {
                    properties = new HybridDictionary();
                }
                return properties;
            }
        }

        /// <summary>
        /// Gets or sets the availability of this command in the source view. Some designer actions 
        /// have no effect on the source code and are excluded from the list of available commands in chrome.
        /// </summary>
        public bool ShowInSourceView
        {
            get
            {
                return showInSourceView;
            }
            set
            {
                showInSourceView = value;
            }
        }
    }
}

