package com.neastwest.imagesiphon;

import android.app.IntentService;
import android.content.Intent;
import android.util.Log;

public class BackgroundIntentService extends IntentService {

    private static final String TAG = "com.neastwest.imagesiphon";

    public BackgroundIntentService() {

        super("backgroundIntentService");
    }

    @Override
    protected void onHandleIntent(Intent intent) {
        // background service
        Log.i(TAG, "service started");

    }
}
