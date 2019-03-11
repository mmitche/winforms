// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.ComponentModel.Design {
    using System;
    using System.Collections;
    using System.Diagnostics;

    /// <summary>
    /// To be provided.
    /// </summary>
    [System.Runtime.InteropServices.ComVisible(true)]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name = "FullTrust")]
    [System.Security.SecurityCritical]
    public class DesignerActionListCollection : CollectionBase
    {

        /// <summary>
        /// To be provided.
        /// </summary>
        public DesignerActionListCollection()
        {
        }

        internal DesignerActionListCollection(DesignerActionList actionList)
        {
            this.Add(actionList);
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public DesignerActionListCollection(DesignerActionList[] value)
        {
            AddRange(value);
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public DesignerActionList this[int index]
        {
            get
            {
                return (DesignerActionList)(List[index]);
            }
            set
            {
                List[index] = value;
            }
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public int Add(DesignerActionList value)
        {
            return List.Add(value);
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public void AddRange(DesignerActionList[] value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            for (int i = 0; ((i) < (value.Length)); i = ((i) + (1)))
            {
                this.Add(value[i]);
            }
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public void AddRange(DesignerActionListCollection value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            int currentCount = value.Count;
            for (int i = 0; i < currentCount; i = ((i) + (1)))
            {
                this.Add(value[i]);
            }
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public void Insert(int index, DesignerActionList value)
        {
            List.Insert(index, value);
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public int IndexOf(DesignerActionList value)
        {
            return List.IndexOf(value);
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public bool Contains(DesignerActionList value)
        {
            return List.Contains(value);
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public void Remove(DesignerActionList value)
        {
            List.Remove(value);
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        public void CopyTo(DesignerActionList[] array, int index)
        {
            List.CopyTo(array, index);
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        protected override void OnSet(int index, object oldValue, object newValue)
        {
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        protected override void OnInsert(int index, object value)
        {
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        protected override void OnClear()
        {
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        protected override void OnRemove(int index, object value)
        {
        }

        /// <summary>
        /// To be provided.
        /// </summary>
        protected override void OnValidate(object value)
        {
            Debug.Assert(value != null, "Don't add null actionlist!");
        }
    }
}


