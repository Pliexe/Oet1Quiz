package com.pliexe.oet1quiz

import android.content.res.Configuration
import android.graphics.Bitmap
import android.graphics.BitmapFactory
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.view.View
import android.widget.*
import androidx.appcompat.app.AlertDialog
import androidx.appcompat.app.AppCompatDelegate
import androidx.core.view.children


class MainActivity : AppCompatActivity() {
    val gameManager = GameManager(this)

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        mainLoad()
    }

    fun checkChange(view: View) {
        if(findViewById<Switch>(R.id.nightmodeSwitch).isChecked)
        {
            delegate.localNightMode = AppCompatDelegate.MODE_NIGHT_YES;
            applicationContext.resources.configuration.uiMode = Configuration.UI_MODE_NIGHT_YES
        } else {
            delegate.localNightMode = AppCompatDelegate.MODE_NIGHT_NO;
            applicationContext.resources.configuration.uiMode = Configuration.UI_MODE_NIGHT_NO
        }
    }

    fun mainLoad() {
        if(isNightMode()) findViewById<Switch>(R.id.nightmodeSwitch).isChecked = true
    }

    fun isNightMode(): Boolean {
        return applicationContext.resources.configuration.uiMode.and(Configuration.UI_MODE_NIGHT_MASK) == Configuration.UI_MODE_NIGHT_YES
    }

    fun getBitmap(id: Int): Bitmap? {
        return BitmapFactory.decodeResource(applicationContext.resources, id)
    }

    fun start_Button(view: View) {
        gameManager.StartGame(getRandomizedQuestions(), this)
    }

    fun next_button_clicked(view: View) {
        gameManager.Submit()
    }

    fun backToMenu_Button(view: View) {
        gameManager.EndGame()
    }

    fun continueButton(view: View) {
        gameManager.Next()
    }

    fun backFromFailButton(view: View) {
        gameManager.Back()
    }
}