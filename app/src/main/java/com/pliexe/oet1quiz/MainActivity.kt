package com.pliexe.oet1quiz

import android.content.res.Configuration
import android.graphics.Bitmap
import android.graphics.BitmapFactory
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.view.View
import android.widget.*
import androidx.core.view.children


class MainActivity : AppCompatActivity() {
    val gameManager = GameManager(this)

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }

    fun isNightMode(): Boolean {
        return applicationContext.resources.configuration.uiMode.and(Configuration.UI_MODE_NIGHT_MASK) == Configuration.UI_MODE_NIGHT_YES
    }

    fun getBitmap(id: Int): Bitmap? {
        return BitmapFactory.decodeResource(applicationContext.resources, id)
    }

    fun start_Button(view: View) {

        gameManager.StartGame(getRandomizedQuestions().subList(0, 3), this)
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