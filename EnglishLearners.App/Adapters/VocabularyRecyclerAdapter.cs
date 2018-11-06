using System;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using Android.Content;
using EnglishLearners.App.Models;
using System.Collections.Generic;

namespace EnglishLearners.App.Adapters
{
    public class VocabularyRecyclerAdapter : RecyclerView.Adapter
    {
        //public event EventHandler<VocabularyRecyclerAdapterClickEventArgs> ItemClick;
        //public event EventHandler<VocabularyRecyclerAdapterClickEventArgs> ItemLongClick;
        //string[] items;
        public List<VocabularyModel> mVacabularies;

        public Context mContext;
        public LayoutInflater mLayoutInflater;


        public VocabularyRecyclerAdapter(List<VocabularyModel> vacabularies, Context context)
        {
            mVacabularies = vacabularies;
            mContext = context;
            mLayoutInflater = LayoutInflater.From(mContext);
        }

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = mLayoutInflater.Inflate(Resource.Layout.item_vacabulary_list, parent, false);

            VocabularyRecyclerAdapterViewHolder viewHolder = new VocabularyRecyclerAdapterViewHolder(itemView, mContext);

            return viewHolder;

            //////Setup your layout here
            ////View itemView = null;
            //////var id = Resource.Layout.__YOUR_ITEM_HERE;
            //////itemView = LayoutInflater.From(parent.Context).
            //////       Inflate(id, parent, false);

            ////var vh = new VocabularyRecyclerAdapterViewHolder(itemView, OnClick, OnLongClick);
            ////return vh;
        }

        // Replace the contents of a view (invoked by the layout manager)
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            VocabularyModel vocabulary = mVacabularies[position];
            ((VocabularyRecyclerAdapterViewHolder)viewHolder).mTextTitle.Text = vocabulary.Title;
            ((VocabularyRecyclerAdapterViewHolder)viewHolder).mTextDefinition.Text = vocabulary.Definition;
            ((VocabularyRecyclerAdapterViewHolder)viewHolder).mCurrentPosition = position;
            //((VocabularyRecyclerAdapterViewHolder)viewHolder).ItemView.Click += ItemView_Click;

            ////var item = items[position];

            ////// Replace the contents of the view with that element
            ////var holder = viewHolder as VocabularyRecyclerAdapterViewHolder;
            //////holder.TextView.Text = items[position];
        }


        //private void ItemView_Click(object sender, EventArgs e)
        //{
        //    Intent intent = new Intent(mContext, typeof(VocabularyActivity));


        //    intent.PutExtra(VocabularyEditorActivity.VocabularyPosition, mCurrentPosition);
        //    context.StartActivity(intent);
        //    return null;
        //}

        public override int ItemCount => mVacabularies.Count;

        //void OnClick(VocabularyRecyclerAdapterClickEventArgs args) => ItemClick?.Invoke(this, args);
        //void OnLongClick(VocabularyRecyclerAdapterClickEventArgs args) => ItemLongClick?.Invoke(this, args);

    }

    public class VocabularyRecyclerAdapterViewHolder : RecyclerView.ViewHolder
    {
        public TextView mTextTitle { get; set; }
        public TextView mTextDefinition { get; set; }
        public int mCurrentPosition;

        public VocabularyRecyclerAdapterViewHolder(View itemView/*, Action<VocabularyRecyclerAdapterClickEventArgs> clickListener,
                            Action<VocabularyRecyclerAdapterClickEventArgs> longClickListener*/, Context mContext) : base(itemView)
        {
            mTextTitle = itemView.FindViewById<TextView>(Resource.Id.text_title);
            mTextDefinition = itemView.FindViewById<TextView>(Resource.Id.text_definition);
            //TextView = v;
            //itemView.Click += (sender, e) => clickListener(new VocabularyRecyclerAdapterClickEventArgs { View = itemView, Position = AdapterPosition });
            //itemView.LongClick += (sender, e) => longClickListener(new VocabularyRecyclerAdapterClickEventArgs { View = itemView, Position = AdapterPosition });


            //itemView.Click += OnClick(itemView, mContext);
            itemView.Click += delegate
            {
                Intent intent = new Intent(mContext, typeof(VocabularyEditorActivity));
                intent.PutExtra(VocabularyEditorActivity.VocabularyPosition, mCurrentPosition);
                mContext.StartActivity(intent); 
            };



        }

        private EventHandler OnClick(View itemView, Context context)
        {
            Intent intent = new Intent(context, typeof(VocabularyActivity));
            intent.PutExtra(VocabularyEditorActivity.VocabularyPosition, mCurrentPosition);
            context.StartActivity(intent);
            return null;
        }


    }

    //public class VocabularyRecyclerAdapterClickEventArgs : EventArgs
    //{
    //    public View View { get; set; }
    //    public int Position { get; set; }
    //}
}