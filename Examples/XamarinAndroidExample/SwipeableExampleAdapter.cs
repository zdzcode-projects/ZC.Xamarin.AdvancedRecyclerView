using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Swipeable;
using XamarinAndroidExample;

namespace XamarinAndroidExample
{
    public class SwipeableExampleAdapter : RecyclerView.Adapter
    {
        private static string TAG = "MySwipeableItemAdapter";        


        Context context;

        private List<string> _list;

        public SwipeableExampleAdapter(Context context)
        {
            this.context = context;

            _list = new List<string>();


        }

        public override int ItemCount => throw new NotImplementedException();

        public override void OnBindViewHolder(RecyclerView.ViewHolder holderItem, int position)
        {
            var holder = (MyViewHolder)holderItem;


            var item = _list[position];

            // set listeners
            // (if the item is *pinned*, click event comes to the itemView)
            //holder.ItemView.setOnClickListener(mItemViewOnClickListener);
            // (if the item is *not pinned*, click event comes to the mContainer)
            holder.GetSwipeableContainerView().Click += SwipeableExampleAdapter_Click;

            // set text
            holder.mTextView.Text = item;

            // set background resource (target view ID: container)
            SwipeableItemState swipeState = holder.SwipeState;

            //if (swipeState.IsUpdated)
            //{
            //    int bgResId;

            //    if (swipeState.IsActive)
            //    {
            //        bgResId = Resource.Drawable.bg_item_swiping_active_state;
            //    }
            //    else if (swipeState.IsSwiping)
            //    {
            //        bgResId = Resource.Drawable.bg_item_swiping_state;
            //    }
            //    else
            //    {
            //        bgResId = Resource.Drawable.bg_item_normal_state;
            //    }

            //    //holder.GetSwipeableContainerView.setBackgroundResource(bgResId);
            //}

            // set swiping properties
            //holder.SwipeItemHorizontalSlideAmount = item.isPinned() ? Swipeable.OUTSIDE_OF_THE_WINDOW_LEFT : 0);
        }

        private void SwipeableExampleAdapter_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            LayoutInflater inflater = LayoutInflater.From(parent.Context);
            View v = inflater.Inflate(Android.Resource.Layout.SimpleListItem1, parent, false);
            return new MyViewHolder(v);
        }
    }

    //public static class MyViewHolder extends AbstractSwipeableItemViewHolder
    //{
    //    public FrameLayout mContainer;
    //public TextView mTextView;

    //public MyViewHolder(View v)
    //{
    //    super(v);
    //    mContainer = v.findViewById(R.id.container);
    //    mTextView = v.findViewById(android.R.id.text1);
    //}

    //@Override
    //@NonNull
    //    public View getSwipeableContainerView()
    //{
    //    return mContainer;
    //}


    public class MyViewHolder : AbstractSwipeableItemViewHolder
    {
        public FrameLayout mContainer;
        public TextView mTextView;

        public MyViewHolder(View itemView) : base(itemView)
        {
            mContainer = itemView.FindViewById<FrameLayout>(Resource.Id.container);
            mTextView = itemView.FindViewById<TextView>(Android.Resource.Id.Text1);
        }

        public View GetSwipeableContainerView()
        {
            return mContainer;
        }
    }
}