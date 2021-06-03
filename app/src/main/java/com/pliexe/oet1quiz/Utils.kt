package com.pliexe.oet1quiz

fun getRandom(min: Int, max: Int): Int {
    return (min..max).random()
}

fun <T> getRandomAnwser(anwsers: List<T>, notAllowed: T): T {
    val rng = anwsers[getRandom(0, anwsers.size - 1)]

    return if(rng == notAllowed) getRandomAnwser(anwsers, notAllowed)
    else rng
}

fun <T> getRandomAnwser(anwsers: List<T>, notAllowed: T, notAllowed2: T): T {
    val rng = anwsers[getRandom(0, anwsers.size - 1)]

    return if(rng == notAllowed || rng == notAllowed2) getRandomAnwser(anwsers, notAllowed, notAllowed2)
    else rng
}