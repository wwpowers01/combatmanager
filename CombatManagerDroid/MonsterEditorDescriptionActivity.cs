
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CombatManagerDroid
{
    [Activity (Label = "Monster Editor - Description", Theme = "@android:style/Theme.Light.NoTitleBar")]   
    class MonsterEditorDescriptionActivity : MonsterEditorActivity
    {
        protected override int LayoutID
        {
            get
            {
                return Resource.Layout.MonsterEditorDescription;
            }
        }
    }
}
