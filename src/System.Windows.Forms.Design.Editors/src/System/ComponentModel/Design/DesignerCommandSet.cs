// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.ComponentModel;

namespace System.ComponentModel.Design
{


    /// <include file='doc\DesginerCommandSet.uex' path='docs/doc[@for="DesginerCommandSet"]/*' />
    /// <devdoc>
    ///     [to be provided]
    /// </devdoc>
    public class DesignerCommandSet
    {

        /// <include file='doc\DesginerCommandSet.uex' path='docs/doc[@for="GetCommands"]/*' />
        /// <devdoc>
        ///     [to be provided]
        /// </devdoc>
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

        /// <include file='doc\DesginerCommandSet.uex' path='docs/doc[@for="Verbs"]/*' />
        /// <devdoc>
        ///     [to be provided]
        /// </devdoc>
        public DesignerVerbCollection Verbs
        {
            get
            {
                return (DesignerVerbCollection)GetCommands("Verbs");
            }
        }

        /// <include file='doc\DesginerCommandSet.uex' path='docs/doc[@for="Actions"]/*' />
        /// <devdoc>
        ///     [to be provided]
        /// </devdoc>
        public DesignerActionListCollection ActionLists
        {
            get
            {
                return (DesignerActionListCollection)GetCommands("ActionLists");
            }
        }
    }
}

