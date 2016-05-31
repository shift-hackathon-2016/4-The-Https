package hr.shiftconference.hackathon.thehttps.eventsonar.services;

import java.util.List;

import hr.shiftconference.hackathon.thehttps.eventsonar.models.database.Event;
import retrofit2.Call;
import retrofit2.http.GET;

/**
 * Created by ANTE on 31.5.2016..
 */
public interface APIEndpoints {
    @GET("eventsapi/GetAllEventsForUser")
    Call<List<Event>> getAllEvents();
}
