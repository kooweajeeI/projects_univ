package com.example.termproject;

import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ImageButton;
import android.widget.TextView;
import android.widget.Toast;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;

public class MainActivity extends AppCompatActivity implements View.OnClickListener, OnDatabaseCallback {
    private static final String TAG = "MainActivity";

    ImageButton inputBtn;
    ImageButton backBtn;
    ImageButton marketBtn;
    TextView todayText;
    EditFragment inputFragment;
    ListFragment listFragment;
    EditFragment editFragment;

    ImageButton lotte;
    ImageButton home;
    ImageButton em;
    ImageButton cou;

    View editMenu;
    View listMenu;
    View marketTab;
    boolean isMarketTab = false;
    StuffDatabase database;

    FragmentManager fragmentManager;
    FragmentTransaction fragmentTransaction;

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        listMenu = findViewById(R.id.listMenu);

        editMenu = findViewById(R.id.editMenu);
        editMenu.setVisibility(View.GONE);

        marketTab = findViewById(R.id.marketTab);
        marketTab.setVisibility(View.GONE);

        todayText = findViewById(R.id.today);
        todayText.setText(getToday());

        marketBtn = findViewById(R.id.marketBtn);
        marketBtn.setOnClickListener(this);

        inputBtn = (ImageButton) findViewById(R.id.inputBtn);
        inputBtn.setOnClickListener(this);

        backBtn = (ImageButton) findViewById(R.id.backBtn);
        backBtn.setOnClickListener(this);

        lotte = (ImageButton) findViewById(R.id.lotte);
        home = (ImageButton) findViewById(R.id.homePlus);
        cou = (ImageButton) findViewById(R.id.coupang);
        em = (ImageButton) findViewById(R.id.emart);

        //fragment 세팅
        inputFragment = new EditFragment();
        listFragment = new ListFragment();
        getSupportFragmentManager().beginTransaction().replace(R.id.container, listFragment).commit();


        //database 세팅
        if (database != null) {
            database.close();
            database = null;
        }

        database = StuffDatabase.getInstance(this);

        boolean isOpen = database.open();
        if (isOpen) {
            Log.d(TAG, "Stuff database is open.");
        } else {
            Log.d(TAG, "Stuff database is not open.");
        }
    }

    protected void onDestroy() {
        // close database
        if (database != null) {
            database.close();
            database = null;
        }
        super.onDestroy();
    }

    //오늘 날짜 설정 메소드
    public String getToday() {
        SimpleDateFormat today = new SimpleDateFormat("yyyy / MM / dd");
        return "[오늘 날짜]\n" + today.format(new Date());
    }

    //리스트로 돌아가기 메소드
    public void backMain() {
        listMenu.setVisibility(View.VISIBLE);
        editMenu.setVisibility(View.GONE);
        //애니메이션 설정
        fragmentManager = getSupportFragmentManager();
        fragmentTransaction = fragmentManager.beginTransaction();
        fragmentTransaction.setCustomAnimations(R.anim.enter_from_right, R.anim.exit_to_right, R.anim.enter_from_right, R.anim.exit_to_right);
        fragmentTransaction.addToBackStack(null);
        fragmentTransaction.replace(R.id.container, listFragment);
        fragmentTransaction.commit();
    }

    //input 버튼 눌렀을 때
    public void openInput() {
        listMenu.setVisibility(View.GONE);
        editMenu.setVisibility(View.VISIBLE);
        inputFragment = new EditFragment();
        //애니메이션 설정
        fragmentManager = getSupportFragmentManager();
        fragmentTransaction = fragmentManager.beginTransaction();
        fragmentTransaction.setCustomAnimations(R.anim.enter_from_right, R.anim.exit_to_right, R.anim.enter_from_right, R.anim.exit_to_right);
        fragmentTransaction.addToBackStack(null);
        fragmentTransaction.replace(R.id.container, inputFragment);
        fragmentTransaction.commit();

    }

    //리스트에서 아이템 선택했을 때.
    public void openEdit(String name, String date) {
        listMenu.setVisibility(View.GONE);
        editMenu.setVisibility(View.VISIBLE);

        editFragment = new EditFragment(name, date);
        fragmentManager = getSupportFragmentManager();
        fragmentTransaction = fragmentManager.beginTransaction();
        fragmentTransaction.setCustomAnimations(R.anim.enter_from_right, R.anim.exit_to_right, R.anim.enter_from_right, R.anim.exit_to_right);
        fragmentTransaction.addToBackStack(null);
        fragmentTransaction.replace(R.id.container, editFragment);
        fragmentTransaction.commit();
    }

    //마켓탭 열기
    public void openMarketTab(){
        if(isMarketTab==true){
            isMarketTab = false;
            marketTab.setVisibility(View.GONE);
        }
        else {
            isMarketTab = true;
            marketTab.setVisibility(View.VISIBLE);
            marketTab.bringToFront();
        }
    }

    @Override
    public void onClick(View v) {
        Intent intent;
        switch (v.getId()) {
            case R.id.inputBtn:
                openInput();
                break;
            case R.id.backBtn:
                backMain();
                break;
            case R.id.marketBtn:
                openMarketTab();
                break;
            case R.id.lotte:
                intent = new Intent(Intent.ACTION_VIEW, Uri.parse("http://m.lottemart.com/"));
                startActivity(intent);
                break;
            case R.id.homePlus:
                intent = new Intent(Intent.ACTION_VIEW, Uri.parse("http://m.homeplus.co.kr/"));
                startActivity(intent);
                break;
            case R.id.coupang:
                intent = new Intent(Intent.ACTION_VIEW, Uri.parse("https://m.coupang.com/nm/"));
                startActivity(intent);
                break;
            case R.id.emart:
                intent = new Intent(Intent.ACTION_VIEW, Uri.parse("http://m.emart.ssg.com/"));
                startActivity(intent);
                break;
        }
    }

    @Override
    public void insert(String name, String date) {
        database.insertRecord(name, date);
        Toast.makeText(getApplicationContext(), name + "을(를) 추가했습니다.", Toast.LENGTH_LONG).show();
    }

    @Override
    public void update(String oldName, String name, String date) {
        database.updateRecord(oldName, name, date);
        Toast.makeText(getApplicationContext(), name + "을(를) 수정했습니다.", Toast.LENGTH_LONG).show();
    }

    @Override
    public void delete(String name) {
        database.deleteRecord(name);
        Toast.makeText(getApplicationContext(), name + "을(를) 삭제했습니다.", Toast.LENGTH_LONG).show();
    }

    @Override
    public String search(String name) {
        String r;
        r = database.searchRecord(name);
        return r;
    }

    @Override
    public ArrayList<StuffInfo> selectAll() {
        ArrayList<StuffInfo> result = database.selectAll();

        return result;
    }

    @Override
    public void onBackPressed() {
        super.onBackPressed();
        backMain();
    }
}
