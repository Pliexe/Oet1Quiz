package com.pliexe.oet1quiz

import android.graphics.*
import android.graphics.drawable.Drawable
import android.util.Log

fun getRandom(min: Int, max: Int, notAllowed: Int): Int {
    val ran = (min..max).random()
    return if(ran == notAllowed) getRandom(min, max, notAllowed)
    else ran
}

fun getRandom(min: Int, max: Int, notAllowed: Int, notAllowed2: Int): Int {
    val ran = (min..max).random()
    return if(ran == notAllowed || ran == notAllowed2) getRandom(min, max, notAllowed, notAllowed2)
    else ran
}

fun getRandom(min: Int, max: Int): Int {
    return (min..max).random()
}

fun <T> getRandomAnwser(anwsers: List<T>, notAllowed: T): T {
    return anwsers[getRandom(0, anwsers.size - 1, anwsers.indexOf(notAllowed))]
}

fun <T> getRandomAnwser(anwsers: List<T>, notAllowed: T, notAllowed2: T): T {
    return anwsers[getRandom(0, anwsers.size - 1, anwsers.indexOf(notAllowed), anwsers.indexOf(notAllowed2))]
}

val NEGATIVE_FILTER = floatArrayOf(
    -1.0f,     .0f,     .0f,    .0f,  255.0f,
    .0f,   -1.0f,     .0f,    .0f,  255.0f,
    .0f,     .0f,   -1.0f,    .0f,  255.0f,
    .0f,     .0f,     .0f,   1.0f,     .0f
)

fun Bitmap.invertColors(): Bitmap? {
    val bitmap = Bitmap.createBitmap(
        width,
        height,
        Bitmap.Config.ARGB_8888
    )

    val matrixInvert = ColorMatrix().apply {
        set(
            floatArrayOf(
                -1.0f, 0.0f, 0.0f, 0.0f, 255.0f,
                0.0f, -1.0f, 0.0f, 0.0f, 255.0f,
                0.0f, 0.0f, -1.0f, 0.0f, 255.0f,
                0.0f, 0.0f, 0.0f, 1.0f, 0.0f
            )
        )
    }

    val paint = Paint()
    ColorMatrixColorFilter(matrixInvert).apply {
        paint.colorFilter = this
    }

    Canvas(bitmap).drawBitmap(this, 0f, 0f, paint)
    return bitmap
}