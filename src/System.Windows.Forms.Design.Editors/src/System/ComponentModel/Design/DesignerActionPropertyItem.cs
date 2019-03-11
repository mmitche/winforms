// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.ComponentModel.Design
{

    using System;
    using System.ComponentModel;

    /// <summary>
    /// To be provided.
    /// </summary>
    public sealed class DesignerActionPropertyItem : DesignerActionItem
    {

        private string memberName;
        private IComponent relatedComponent;


        /// <summary>
        /// To be provided.
        /// </summary>
        public DesignerActionPropertyItem(string memberName, string displayName, string category, string description)
            : base(displayName, category, description)
        {
            this.memberName = memberName;
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public DesignerActionPropertyItem(string memberName, string displayName)
            : this(memberName, displayName, null, null)
        {
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public DesignerActionPropertyItem(string memberName, string displayName, string category)
            : this(memberName, displayName, category, null)
        {
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public string MemberName => memberName;

        /// <summary>
        /// To be provided.
        /// </summary>
        public IComponent RelatedComponent
        {
            get
            {
                return relatedComponent;
            }
            set
            {
                relatedComponent = value;
            }
        }
    }
}

