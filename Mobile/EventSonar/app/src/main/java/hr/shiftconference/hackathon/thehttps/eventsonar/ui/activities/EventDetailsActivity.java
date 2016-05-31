package hr.shiftconference.hackathon.thehttps.eventsonar.ui.activities;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

import com.google.android.gms.maps.GoogleMap;

import hr.shiftconference.hackathon.thehttps.eventsonar.R;

public class EventDetailsActivity extends AppCompatActivity {
    private GoogleMap googleMap;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_event_details);
    }
}
