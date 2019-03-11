// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using Xunit;

namespace System.Windows.Forms.Design.Editors.Tests
{
    public class DesignerActionItemTests
    {
        const string MEMBER_NAME = "memberName";
        const string DISPLAY_NAME = "displayName";
        const string CATEGORY_NAME = "categoryName";
        const string DESCRIPTION = "This is the description string";

        [Fact]
        public void DesignerActionPropertyItemTest()
        {

            var designerActionItemProp = new DesignerActionPropertyItem(MEMBER_NAME, DISPLAY_NAME, CATEGORY_NAME, DESCRIPTION);
            Assert.Equal(MEMBER_NAME, designerActionItemProp.MemberName);
            Assert.Equal(DISPLAY_NAME, designerActionItemProp.DisplayName);
            Assert.Equal(CATEGORY_NAME, designerActionItemProp.Category);
            Assert.Equal(DESCRIPTION, designerActionItemProp.Description);
        }

        [Fact]
        public DesignerActionList ActionListAndCollectionTest()
        {
            var component = new Component();
            var actionList = new TestDesignerActionList(component);
            Assert.Equal(component, actionList.Component);

            var sortedItems = actionList.GetSortedActionItems();
            Assert.Equal(TestDesignerActionList.METHOD_ONE_DESCRIPTION, sortedItems[0].Description);
            Assert.Equal(TestDesignerActionList.METHOD_ONE_CATEGORY, sortedItems[0].Category);
            Assert.Equal(TestDesignerActionList.METHOD_ONE_DISPLAYNAME, sortedItems[0].DisplayName);
            Assert.Equal(TestDesignerActionList.METHOD_TWO_DESCRIPTION, sortedItems[1].Description);
            Assert.Equal(TestDesignerActionList.METHOD_TWO_CATEGORY, sortedItems[1].Category);
            Assert.Equal(TestDesignerActionList.METHOD_TWO_DISPLAYNAME, sortedItems[1].DisplayName);
            Assert.Equal(TestDesignerActionList.PROP_ONE_DESCRIPTION, sortedItems[2].Description);
            Assert.Equal(TestDesignerActionList.PROP_ONE_CATEGORY, sortedItems[2].Category);
            Assert.Equal(TestDesignerActionList.PROP_ONE_DISPLAYNAME, sortedItems[2].DisplayName);
            Assert.Equal(TestDesignerActionList.PROP_TWO_DESCRIPTION, sortedItems[3].Description);
            Assert.Equal(TestDesignerActionList.PROP_TWO_CATEGORY, sortedItems[3].Category);
            Assert.Equal(TestDesignerActionList.PROP_TWO_DISPLAYNAME, sortedItems[3].DisplayName);

            return actionList;
        }

        [Fact]
        public void DesignerActionPropertyMethodItemTest()
        {
            var actionList = ActionListAndCollectionTest();

            var designerActionItemMethod = new DesignerActionMethodItem(actionList, MEMBER_NAME, DISPLAY_NAME, CATEGORY_NAME, DESCRIPTION);
            Assert.Equal(MEMBER_NAME, designerActionItemMethod.MemberName);
            Assert.Equal(DISPLAY_NAME, designerActionItemMethod.DisplayName);
            Assert.Equal(CATEGORY_NAME, designerActionItemMethod.Category);
            Assert.Equal(DESCRIPTION, designerActionItemMethod.Description);
        }
    }

    public class TestDesignerActionList : DesignerActionList
    {
        public const string PROP_ONE_DESCRIPTION = nameof(TestDesignerActionList.TestPropertyOne) + "Description";
        public const string PROP_ONE_CATEGORY = nameof(TestDesignerActionList.TestPropertyOne) + "Category";
        public const string PROP_ONE_DISPLAYNAME = nameof(TestDesignerActionList.TestPropertyOne) + "DisplayName";
        public const string PROP_TWO_DESCRIPTION = nameof(TestDesignerActionList.TestPropertyTwo) + "Description";
        public const string PROP_TWO_CATEGORY = nameof(TestDesignerActionList.TestPropertyTwo) + "Category";
        public const string PROP_TWO_DISPLAYNAME = nameof(TestDesignerActionList.TestPropertyTwo) + "DisplayName";

        public const string METHOD_ONE_DESCRIPTION = nameof(TestDesignerActionList.TestMethodOne) + "Description";
        public const string METHOD_ONE_CATEGORY = nameof(TestDesignerActionList.TestMethodOne) + "Category";
        public const string METHOD_ONE_DISPLAYNAME = nameof(TestDesignerActionList.TestMethodOne) + "DisplayName";
        public const string METHOD_TWO_DESCRIPTION = nameof(TestDesignerActionList.TestMethodTwo) + "Description";
        public const string METHOD_TWO_CATEGORY = nameof(TestDesignerActionList.TestMethodTwo) + "Category";
        public const string METHOD_TWO_DISPLAYNAME = nameof(TestDesignerActionList.TestMethodTwo) + "DisplayName";


        public TestDesignerActionList(IComponent component) : base(component) { }

        [Description(PROP_ONE_DESCRIPTION),
         Category(PROP_ONE_CATEGORY),
         DisplayName(PROP_ONE_DISPLAYNAME)]
        public string TestPropertyOne { get; set; }

        [Description(PROP_TWO_DESCRIPTION),
         Category(PROP_TWO_CATEGORY),
         DisplayName(PROP_TWO_DISPLAYNAME)]
        public string TestPropertyTwo { get; set; }

        [Description(METHOD_ONE_DESCRIPTION),
         Category(METHOD_ONE_CATEGORY),
         DisplayName(METHOD_ONE_DISPLAYNAME)]
        public void TestMethodOne() { throw new NotImplementedException(); }

        [Description(METHOD_TWO_DESCRIPTION),
         Category(METHOD_TWO_CATEGORY),
         DisplayName(METHOD_TWO_DISPLAYNAME)]
        public void TestMethodTwo() { throw new NotImplementedException(); }
    }
}
