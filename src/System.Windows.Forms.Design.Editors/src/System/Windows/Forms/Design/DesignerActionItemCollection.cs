// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.ComponentModel.Design {
    using System;
    using System.Collections;
      
    // <include file='doc\DesignerActionItemCollection.uex' path='docs/doc[@for="DesignerActionItemCollection"]/*' />
    /// <devdoc>
    ///     [tbd]
    /// </devdoc>
    public class DesignerActionItemCollection : CollectionBase
    {
        public DesignerActionItemCollection()    {
        }

        public DesignerActionItem this[int index]  {
            get {
                return (DesignerActionItem)(List[index]);
            }
            set {
                List[index] = value;
            }
        }

        public int Add(DesignerActionItem value)   {
            int index = List.Add(value);
            return index;
        }

        public bool Contains(DesignerActionItem value)   {
            return List.Contains(value);
        }

        public void CopyTo(DesignerActionItem[] array, int index)    {
            List.CopyTo(array, index);
        }

        public int IndexOf(DesignerActionItem value)   {
            return List.IndexOf(value);
        }

        public void Insert(int index, DesignerActionItem value)   {
            List.Insert(index, value);
        }

        public void Remove(DesignerActionItem value)     {
            List.Remove(value);
        }
    }
}

