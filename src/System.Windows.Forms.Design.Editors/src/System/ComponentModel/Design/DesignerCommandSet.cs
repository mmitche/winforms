// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.ComponentModel;

namespace System.ComponentModel.Design
{
    /// <summary>
    /// To be provided.
    /// </summary>
    public class DesignerCommandSet
    {

        /// <summary>
        /// To be provided.
        /// </summary>
        public virtual ICollection GetCommands(string name)
        {
            return null;
        }

        /*
                public DesignerActionList CreateVerbsActionList() {
                    DesignerActionList result = null;
                    DesignerVerbCollection verbs = Verbs;
                    if(verbs != null) {
                        DesignerVerb[] verbsArray = new DesignerVerb[verbs.Count];
                        verbs.CopyTo(verbsArray, 0);
                        result = new DesignerActionVerbList(verbsArray);
                    } 
                    return result;
                }
                */

        /// <summary>
        /// To be provided.
        /// </summary>
        public DesignerVerbCollection Verbs => (DesignerVerbCollection)GetCommands("Verbs");

        /// <summary>
        /// To be provided.
        /// </summary>
        public DesignerActionListCollection ActionLists => (DesignerActionListCollection)GetCommands("ActionLists");
    }
}

