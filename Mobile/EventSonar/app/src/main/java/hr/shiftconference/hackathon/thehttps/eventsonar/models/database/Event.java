package hr.shiftconference.hackathon.thehttps.eventsonar.models.database;

import android.support.annotation.Nullable;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

/**
 * Created by ANTE on 31.5.2016..
 */
public class Event {
    // FIELDS
    @SerializedName("Id")
    @Expose
    private int id;
    @SerializedName("Name")
    @Expose
    private String name;
    @SerializedName("Description")
    @Expose
    private String description;
    @SerializedName("StartDate")
    @Expose
    @Nullable
    private Date startDate;
    @SerializedName("EndDate")
    @Expose
    @Nullable
    private Date endDate;
    @SerializedName("Longitude")
    @Expose
    @Nullable
    private float longitude;
    @SerializedName("Latitude")
    @Expose
    @Nullable
    private float latitude;
    @SerializedName("AuthorID")
    @Expose
    private int authorId;
    @SerializedName("TownID")
    @Expose
    private int townId;
    @SerializedName("StateID")
    @Expose
    private int stateId;
    @SerializedName("ImageUrl")
    @Expose
    private String imageURL;
    @SerializedName("Contact")
    @Expose
    private String contact;
    @SerializedName("EventTypeID")
    @Expose
    private int eventTypeId;
    @SerializedName("Radius")
    @Expose
    @Nullable
    private int radius;

    @SerializedName("Comment")
    @Expose
    private List<Comment> comment;
    @SerializedName("Person")
    @Expose
    private Person person;
    @SerializedName("EventType")
    @Expose
    private EventType eventType;
    @SerializedName("EventState")
    @Expose
    private EventState eventState;
    @SerializedName("Town")
    @Expose
    private Town town;
    @SerializedName("EventPerson")
    @Expose
    private List<EventPerson> eventPerson;
    @SerializedName("EventSubscription")
    @Expose
    private List<EventSubscription> eventSubscription;

    // PROPERTIES
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    @Nullable
    public Date getStartDate() {
        return startDate;
    }

    public void setStartDate(@Nullable Date startDate) {
        this.startDate = startDate;
    }

    @Nullable
    public Date getEndDate() {
        return endDate;
    }

    public void setEndDate(@Nullable Date endDate) {
        this.endDate = endDate;
    }

    @Nullable
    public float getLongitude() {
        return longitude;
    }

    public void setLongitude(@Nullable float longitude) {
        this.longitude = longitude;
    }

    @Nullable
    public float getLatitude() {
        return latitude;
    }

    public void setLatitude(@Nullable float latitude) {
        this.latitude = latitude;
    }

    public int getAuthorId() {
        return authorId;
    }

    public void setAuthorId(int authorId) {
        this.authorId = authorId;
    }

    public int getTownId() {
        return townId;
    }

    public void setTownId(int townId) {
        this.townId = townId;
    }

    public int getStateId() {
        return stateId;
    }

    public void setStateId(int stateId) {
        this.stateId = stateId;
    }

    public String getImageURL() {
        return imageURL;
    }

    public void setImageURL(String imageURL) {
        this.imageURL = imageURL;
    }

    public String getContact() {
        return contact;
    }

    public void setContact(String contact) {
        this.contact = contact;
    }

    public int getEventTypeId() {
        return eventTypeId;
    }

    public void setEventTypeId(int eventTypeId) {
        this.eventTypeId = eventTypeId;
    }

    @Nullable
    public int getRadius() {
        return radius;
    }

    public void setRadius(@Nullable int radius) {
        this.radius = radius;
    }

    public List<Comment> getComment() {
        return comment;
    }

    public void setComment(List<Comment> comment) {
        this.comment = comment;
    }

    public Person getPerson() {
        return person;
    }

    public void setPerson(Person person) {
        this.person = person;
    }

    public EventType getEventType() {
        return eventType;
    }

    public void setEventType(EventType eventType) {
        this.eventType = eventType;
    }

    public EventState getEventState() {
        return eventState;
    }

    public void setEventState(EventState eventState) {
        this.eventState = eventState;
    }

    public Town getTown() {
        return town;
    }

    public void setTown(Town town) {
        this.town = town;
    }

    public List<EventPerson> getEventPerson() {
        return eventPerson;
    }

    public void setEventPerson(List<EventPerson> eventPerson) {
        this.eventPerson = eventPerson;
    }

    public List<EventSubscription> getEventSubscription() {
        return eventSubscription;
    }

    public void setEventSubscription(List<EventSubscription> eventSubscription) {
        this.eventSubscription = eventSubscription;
    }

    // CONSTRUCTORS
    public Event() {
        this.comment = new ArrayList<>();
        this.eventPerson = new ArrayList<>();
        this.eventSubscription = new ArrayList<>();
    }
}
