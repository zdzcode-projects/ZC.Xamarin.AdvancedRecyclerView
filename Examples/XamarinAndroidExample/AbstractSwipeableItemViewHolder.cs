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

namespace XamarinAndroidExample
{
    public abstract class AbstractSwipeableItemViewHolder : RecyclerView.ViewHolder, ISwipeableItemViewHolder
    {
        private SwipeableItemState mSwipeState = new SwipeableItemState();

        public int AfterSwipeReaction { get; set; }
        public float MaxDownSwipeAmount { get; set; }
        public float MaxLeftSwipeAmount { get; set; }
        public float MaxRightSwipeAmount { get; set; }
        public float MaxUpSwipeAmount { get; set; }
        public bool ProportionalSwipeAmountModeEnabled { get; set; }
        public float SwipeItemHorizontalSlideAmount { get; set; }
        public float SwipeItemVerticalSlideAmount { get; set; }
        public int SwipeResult { get; set; }

        public SwipeableItemState SwipeState => mSwipeState;

        public int SwipeStateFlags { get; set; }

        public View SwipeableContainerView => _view;

        private View _view;

        public AbstractSwipeableItemViewHolder(View itemView) : base(itemView)
        {            
            _view = itemView;
        }

        public void OnSlideAmountUpdated(float horizontalAmount, float verticalAmount, bool isSwiping)
        {
        }
    }
}