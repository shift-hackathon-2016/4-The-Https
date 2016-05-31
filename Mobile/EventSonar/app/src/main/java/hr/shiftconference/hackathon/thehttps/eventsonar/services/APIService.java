package hr.shiftconference.hackathon.thehttps.eventsonar.services;

import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

/**
 * Created by ANTE on 31.5.2016..
 */
public class APIService {
    private static final String APIRoot = "https://";
    private static Retrofit retrofit;
    private static APIEndpoints service;

    public static APIEndpoints getService() {
        return service;
    }

    public static void setupAPIService() {
        retrofit = new Retrofit.Builder()
                .baseUrl(APIRoot)
                .addConverterFactory(GsonConverterFactory.create())
                .build();
        service = retrofit.create(APIEndpoints.class);
    }
}
