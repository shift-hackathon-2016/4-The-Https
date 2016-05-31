package hr.shiftconference.hackathon.thehttps.eventsonar.adapters;

import android.support.v7.widget.RecyclerView;
import android.view.View;
import android.view.ViewGroup;

/**
 * Created by ANTE on 31.5.2016..
 */
public class EventsRecyclerAdapter extends RecyclerView.Adapter<EventsRecyclerAdapter.QuizViewHolder> {


    @Override
    public QuizViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        return null;
    }

    @Override
    public int getItemCount() {
        return 0;
    }

    @Override
    public void onBindViewHolder(QuizViewHolder holder, int position) {

    }



    class QuizViewHolder extends RecyclerView.ViewHolder {

        public QuizViewHolder(View itemView) {
            super(itemView);
        }
    }
}
