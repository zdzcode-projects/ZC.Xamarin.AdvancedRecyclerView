using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.V7.Widget;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Swipeable;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Touchguard;

namespace XamarinAndroidExample
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private RecyclerView mRecyclerView;
        private RecyclerView.LayoutManager mLayoutManager;
        private RecyclerView.Adapter mAdapter;
        private RecyclerView.Adapter mWrappedAdapter;
        private RecyclerViewSwipeManager mRecyclerViewSwipeManager;
        private RecyclerViewTouchActionGuardManager mRecyclerViewTouchActionGuardManager;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //Com.H6ah4i.Android.Widget.Advrecyclerview.Swipeable.SwipeableItemState

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}