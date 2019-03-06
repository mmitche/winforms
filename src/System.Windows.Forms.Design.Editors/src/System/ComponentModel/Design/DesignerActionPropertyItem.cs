// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.ComponentModel.Design {

    using System;
    using System.ComponentModel;

    /// <include file='doc\DesignerActionPropertyItem.uex' path='docs/doc[@for="DesignerActionPropertyItem"]/*' />
    /// <devdoc>
    ///     [to be provided]
    /// </devdoc>
    public sealed class DesignerActionPropertyItem    : DesignerActionItem {

        private string              memberName;
        private IComponent          relatedComponent;


        /// <include file='doc\DesignerActionPropertyItem.uex' path='docs/doc[@for="DesignerActionPropertyItem.DesignerActionPropertyItem"]/*' />
        /// <devdoc>
        ///     [to be provvided]
        /// </devdoc>
        public DesignerActionPropertyItem(string memberName, string displayName, string category, string description)
            : base( displayName, category, description)
        {
            this.memberName = memberName;
        }

        /// <include file='doc\DesignerActionPropertyItem.uex' path='docs/doc[@for="DesignerActionPropertyItem.DesignerActionPropertyItem2"]/*' />
        /// <devdoc>
        ///     [to be provvided]
        /// </devdoc>
        public DesignerActionPropertyItem(string memberName, string displayName)
            : this(memberName, displayName, null, null) {
        }

        /// <include file='doc\DesignerActionPropertyItem.uex' path='docs/doc[@for="DesignerActionPropertyItem.DesignerActionPropertyItem3"]/*' />
        /// <devdoc>
        ///     [to be provvided]
        /// </devdoc>
        public DesignerActionPropertyItem(string memberName, string displayName, string category)
            : this(memberName, displayName, category, null) {
        }

        /// <include file='doc\DesignerActionPropertyItem.uex' path='docs/doc[@for="DesignerActionPropertyItem.MemberName"]/*' />
        /// <devdoc>
        ///     [to be provvided]
        /// </devdoc>
        public string MemberName {
            get {
                return memberName;
            }
        }

        /// <include file='doc\DesignerActionPropertyItem.uex' path='docs/doc[@for="DesignerActionPropertyItem.RelatedComponent"]/*' />
        /// <devdoc>
        ///     [to be provvided]
        /// </devdoc>
        public IComponent RelatedComponent {
            get {
                return relatedComponent;
            }
            set {
                relatedComponent = value;
            }
        }

    }
}

