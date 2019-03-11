// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.ComponentModel.Design
{

    using System;
    using System.ComponentModel;
    using System.Reflection;

    /// <summary>
    /// To be provided.
    /// </summary>
    public class DesignerActionMethodItem : DesignerActionItem
    {

        private string memberName;
        private bool includeAsDesignerVerb;
        private DesignerActionList actionList;
        private MethodInfo methodInfo;
        private IComponent relatedComponent;

        /// <summary>
        /// To be provided.
        /// </summary>
        public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName, string category, string description, bool includeAsDesignerVerb)
            : base(displayName, category, description)
        {
            this.actionList = actionList;
            this.memberName = memberName;
            this.includeAsDesignerVerb = includeAsDesignerVerb;
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName)
            : this(actionList, memberName, displayName, null, null, false)
        {
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName, bool includeAsDesignerVerb)
            : this(actionList, memberName, displayName, null, null, includeAsDesignerVerb)
        {
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName, string category)
            : this(actionList, memberName, displayName, category, null, false)
        {
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName, string category, bool includeAsDesignerVerb)
            : this(actionList, memberName, displayName, category, null, includeAsDesignerVerb)
        {
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName, string category, string description)
            : this(actionList, memberName, displayName, category, description, false)
        {
        }


        internal DesignerActionMethodItem()
        {
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public virtual string MemberName => memberName;

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

        /// <summary>
        /// To be provided.
        /// </summary>
        public virtual bool IncludeAsDesignerVerb => includeAsDesignerVerb;

        // this is only use for verbs so that a designer action method item can 
        // be converted to a verb. Verbs use an EventHandler to call their invoke
        // so we need a way to translate the EventHandler Invoke into ou own Invoke
        internal void Invoke(object sender, EventArgs args)
        {
            Invoke();
        }

        public virtual void Invoke()
        {
            if (methodInfo == null)
            {
                // we look public AND private or protected methods
                methodInfo = actionList.GetType().GetMethod(memberName, BindingFlags.Default | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            }

            if (methodInfo != null)
            {
                methodInfo.Invoke(actionList, null);
            }
            else
            {
                throw new InvalidOperationException(string.Format(SR.DesignerActionPanel_CouldNotFindMethod, MemberName));
            }
        }
    }
}
