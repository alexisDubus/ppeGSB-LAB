package com.alexis_dubus.testdate;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.DatePicker;

public class MainActivity extends AppCompatActivity {

    public DatePicker monDatePicker;
    public Button monButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        monDatePicker = (DatePicker)findViewById(R.id.datePicker);
        monButton = (Button)findViewById(R.id.buttonAdd);

        monButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                int dayOfMonth = monDatePicker.getDayOfMonth();
                int year = monDatePicker.getYear();
                int month = monDatePicker.getMonth();
                Log.i("test day", ""+dayOfMonth+"");
                Log.i("test year", ""+year+"");
                Log.i("test month", ""+month+"");

            }
        });

    }
}
