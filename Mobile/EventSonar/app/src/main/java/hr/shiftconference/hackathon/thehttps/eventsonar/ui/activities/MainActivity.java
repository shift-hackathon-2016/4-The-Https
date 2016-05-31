package hr.shiftconference.hackathon.thehttps.eventsonar.ui.activities;

import android.support.design.widget.TabLayout;
import android.support.v4.view.ViewPager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.Toolbar;

import hr.shiftconference.hackathon.thehttps.eventsonar.R;
import hr.shiftconference.hackathon.thehttps.eventsonar.services.APIService;
import hr.shiftconference.hackathon.thehttps.eventsonar.ui.adapters.ViewPagerAdapter;
import hr.shiftconference.hackathon.thehttps.eventsonar.models.database.DatabaseModel;
import hr.shiftconference.hackathon.thehttps.eventsonar.ui.fragments.MyEventsFragment;
import hr.shiftconference.hackathon.thehttps.eventsonar.ui.fragments.NearMeFragment;

public class MainActivity extends AppCompatActivity {
    // fields
    Toolbar toolbar;
    ViewPager viewPager;
    ViewPagerAdapter viewPagerAdapter;
    TabLayout tabLayout;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        setupToolbar();
        setupSlidingNavigation();
        APIService.setupAPIService();

        // DatabaseModel context = new DatabaseModel(this);

        //context.getPersons().addAll(APIHelper.Person.Fetch());

        //context.Persons().fetchAll();
        //List<Person> persons = context.Persons().getAll();
    }

    private void setupToolbar() {
        toolbar = (Toolbar) findViewById(R.id.toolbar);
        toolbar.setTitle("Event Sonar");
        toolbar.setSubtitle("not logged in");

        setSupportActionBar(toolbar);
    }

    private void setupSlidingNavigation() {
        // VIEW PAGER
        viewPager = (ViewPager) findViewById(R.id.view_pager);
        viewPagerAdapter = new ViewPagerAdapter(getSupportFragmentManager());

        NearMeFragment nearMeFragment = new NearMeFragment();
        MyEventsFragment myEventsFragment = new MyEventsFragment();
        nearMeFragment.referenceParentContext(this);

        viewPagerAdapter.addFragment(nearMeFragment, "Near Me");
        viewPagerAdapter.addFragment(myEventsFragment, "My Events");
        viewPager.setAdapter(viewPagerAdapter);

        // ------------------------------------------------------------------

        // TABS
        tabLayout = (TabLayout) findViewById(R.id.tab_layout);
        tabLayout.setupWithViewPager(viewPager);
        // tabLayout.getTabAt(0).getIcon();
    }
}
