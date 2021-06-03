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