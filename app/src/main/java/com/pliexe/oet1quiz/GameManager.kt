package com.pliexe.oet1quiz

import android.graphics.ColorMatrixColorFilter
import android.util.Log
import android.view.View
import android.webkit.WebView
import android.widget.ImageView
import android.widget.RadioButton
import android.widget.RadioGroup
import android.widget.TextView
import androidx.core.view.children

class TextQuestion(
    val question: String,
    val anwser1: String,
    val anwser2: String,
    val anwser3: String,
    val correct: Int
) {
    fun updateQuestion(main: MainActivity) {
        val textView = main.findViewById<TextView>(R.id.questionText)
        val imageView = main.findViewById<ImageView>(R.id.question_image)
        val radio1 = main.findViewById<RadioButton>(R.id.radioButton)
        val radio2 = main.findViewById<RadioButton>(R.id.radioButton2)
        val radio3 = main.findViewById<RadioButton>(R.id.radioButton3)

        if(imageView.visibility == View.VISIBLE) imageView.visibility = View.GONE

        textView.text = question
        radio1.text = anwser1
        radio2.text = anwser2
        radio3.text = anwser3
    }

    fun isCorrect(radioID: Int): Boolean {
        return when(radioID) {
            R.id.radioButton -> correct == 1
            R.id.radioButton2 -> correct == 2
            else -> correct == 3
        }
    }
}

class QuestionWithImage(
    val questionText: String,
    val questionImage: Int,
    val isCorrect: Boolean
) {
    fun updateQuestion(main: MainActivity) {
        val textView = main.findViewById<TextView>(R.id.questionText)
        val imageView = main.findViewById<ImageView>(R.id.question_image)
        val radio1 = main.findViewById<RadioButton>(R.id.radioButton)
        val radio2 = main.findViewById<RadioButton>(R.id.radioButton2)
        val radio3 = main.findViewById<RadioButton>(R.id.radioButton3)

        if(main.isNightMode()) {
            val bitmap = main.getBitmap(questionImage)?.invertColors()
            if(bitmap == null) imageView.setImageResource(questionImage)
            else imageView.setImageBitmap(bitmap)
        } else {
            imageView.setImageResource(questionImage)
        }

        if(imageView.visibility == View.GONE) imageView.visibility = View.VISIBLE

        textView.text = questionText
        radio1.text = "Igen"
        radio2.text = "Nem"
        radio3.text = "Nem tudom"
    }

    fun isCorrect(radioID: Int): Boolean {
        return when(radioID) {
            R.id.radioButton -> isCorrect
            R.id.radioButton2 -> !isCorrect
            else -> isCorrect
        }
    }
}

class GameManager(val main: MainActivity) {
    var questions: MutableList<Any>? = null
    var points = 0
    var currentPosition = 0

    fun StartGame(_questions: MutableList<Any>, main: MainActivity) {
        questions = _questions

        main.setContentView(R.layout.activity_quiz_question)
        SetupQuestion()
    }

    private fun SetupQuestion() {
        if(questions.isNullOrEmpty()) return

        ResetSelections()

        if(questions!![currentPosition] is TextQuestion) {
            (questions!![currentPosition] as TextQuestion).updateQuestion(main)
        } else {
            (questions!![currentPosition] as QuestionWithImage).updateQuestion(main)
        }
    }

    fun Submit() {
        if(questions.isNullOrEmpty()) return
        val selectedButton = main.findViewById<RadioGroup>(R.id.radioGroup).checkedRadioButtonId

        if(selectedButton == -1) return

        if(questions!![currentPosition] is QuestionWithImage)
            if(selectedButton == R.id.radioButton3) {
                points--
                main.setContentView(R.layout.quiz_question_skip)
                main.findViewById<TextView>(R.id.pontSzamText).text = "Pont szám: ${points}"
                return
            }

        if(if(questions!![currentPosition] is TextQuestion) (questions!![currentPosition] as TextQuestion).isCorrect(selectedButton) else (questions!![currentPosition] as QuestionWithImage).isCorrect(selectedButton))
        {
            points++
            main.setContentView(R.layout.quiz_question_correct)
            main.findViewById<TextView>(R.id.pontSzamText).text = "Pont szám: ${points}"
        }
        else {
            main.setContentView(R.layout.quiz_question_incorrect)
        }
    }

    fun Next() {
        currentPosition++

        if(currentPosition >= questions!!.size) {
            main.setContentView(R.layout.activity_quiz_question_end)
            main.findViewById<TextView>(R.id.endPontSzam).text = "Pont szám: ${points}/${questions!!.size}"
        }
        else {
            main.setContentView(R.layout.activity_quiz_question)
            SetupQuestion()
        }
    }

    fun Back() {
        points = 0
        currentPosition = 0
        main.setContentView(R.layout.activity_quiz_question)
        SetupQuestion()
    }

    fun EndGame() {
        currentPosition = 0
        questions = null
        points = 0
        main.setContentView(R.layout.activity_main)
        val test = main.findViewById<WebView>(R.id.webView)

        test.loadUrl("https://starrynight-bot.xyz")
    }

    fun ResetSelections() {
        val radiogroup = main.findViewById<RadioGroup>(R.id.radioGroup)

        radiogroup.children.forEach {
            if(it is RadioButton) {
                it.isChecked = false
            }
        }
    }
}