package com.pliexe.oet1quiz

class CorrectQuestion(
    val question: String,
    val correctAnwser: String,
)

class CorrectQuestionWithImage (
    val questionText: String,
    val questionImage: Int
)

val correctQuestions = arrayOf(
    CorrectQuestion("Elektromos töltésmennyiség jelőlése", "Q"),
    CorrectQuestion("Elektromos erők jelőlése", "F"),
    CorrectQuestion("Elektromos erőtér jelőlése", "E"),
    CorrectQuestion("Elektromos potenciál jelőlése", "V"),
    CorrectQuestion("Elektromos feszültség jelőlése", "U"),
    CorrectQuestion("Elektromos munka jelőlése", "A"),
    CorrectQuestion("Elektromos kapacitás jelőlése", "C"),
    CorrectQuestion("Elektromos áram jelőlése", "I"),
    CorrectQuestion("Elektromos ellenállás jelőlése", "R"),
    CorrectQuestion("Elektromos teljesítmény jelőlése", "P"),
    CorrectQuestion("Elektromos potenciál jelőlése", "V"),
    CorrectQuestion("Mágneses erők jelőlése", "F"),
    CorrectQuestion("Mágneses indukció jelőlése", "B"),
    CorrectQuestion("Mágneses erőtér jelőlése", "H"),
    CorrectQuestion("Mágneses fluxus jelőlése", "Φ"),
    CorrectQuestion("Mágneses elenállás jelőlése", "Rm"),
    CorrectQuestion("Mágnesmotoros erő jelőlése", "Fm"),
    CorrectQuestion("Mágneses induktivitás jelőlése", "L"),
    CorrectQuestion("Indukált elektromotoros erő jelőlése", "Ei"),


    CorrectQuestion("Elektromos töltésmennyiség mértékegysége", "[C]"),
    CorrectQuestion("Elektromos erők mértékegysége", "[N]"),
    CorrectQuestion("Elektromos erőtér mértékegysége", "[N/C]"),
    CorrectQuestion("Elektromos potenciál mértékegysége", "[V]"),
    CorrectQuestion("Elektromos feszültség mértékegysége", "[V]"),
    CorrectQuestion("Elektromos munka mértékegysége", "[J]"),
    CorrectQuestion("Elektromos kapacitás mértékegysége", "[F]"),
    CorrectQuestion("Elektromos áram mértékegysége", "[A]"),
    CorrectQuestion("Elektromos ellenállás mértékegysége", "[Ω]"),
    CorrectQuestion("Elektromos teljesítmény mértékegysége", "[W]"),
    CorrectQuestion("Elektromos potenciál mértékegysége", "[V]"),
    CorrectQuestion("Mágneses erők mértékegysége", "[N]"),
    CorrectQuestion("Mágneses indukció mértékegysége", "[T]"),
    CorrectQuestion("Mágneses erőtér mértékegysége", "[A/m]"),
    CorrectQuestion("Mágneses fluxus mértékegysége", "[Wb]"),
    CorrectQuestion("Mágneses elenállás mértékegysége", "[A/Wb]"),
    CorrectQuestion("Mágnesmotoros erő mértékegysége", "[A]"),
    CorrectQuestion("Mágneses induktivitás mértékegysége", "[H]"),
    CorrectQuestion("Indukált elektromotoros erő mértékegysége", "[V]"),


    CorrectQuestionWithImage("Két pontszerű töltés közötti erő:", R.drawable.eq1),
    CorrectQuestionWithImage("Arányossági együttható:", R.drawable.eq2),
    CorrectQuestionWithImage("A pontszerű töltés körüli elektromos erőtér:", R.drawable.eq3),
    CorrectQuestionWithImage("Elektromos potenciál:", R.drawable.eq4),
    CorrectQuestionWithImage("Feszültség:", R.drawable.eq5),
    CorrectQuestionWithImage("Elektromos kapacitás:", R.drawable.eq6),
    CorrectQuestionWithImage("Síkkondenzátorok kapacitása:", R.drawable.eq7),
    CorrectQuestionWithImage("Síkkondenzátorban létrejött elektromos erőtér:", R.drawable.eq8),
    CorrectQuestionWithImage("Eredő kapacitás párhuzamos kapcsolás esetében:", R.drawable.eq9),
    CorrectQuestionWithImage("Eredő kapacitás soros kapcsolás esetében:", R.drawable.eq10),
    CorrectQuestionWithImage("A mágneses erőtér energiája:", R.drawable.eq11),

    CorrectQuestionWithImage("Az elektromos áram erőssége:", R.drawable.eq12),
    CorrectQuestionWithImage("Az áram sűrűsége:", R.drawable.eq13),
    CorrectQuestionWithImage("Elektromos ellenállás:", R.drawable.eq14),
    CorrectQuestionWithImage("Elektromos vezetőképesség:", R.drawable.eq15),
    CorrectQuestionWithImage("Az elektromos ellenállás és a hőmérséklet összefüggése:", R.drawable.eq16),
    CorrectQuestionWithImage("A fajlagos ellenállás és a hőmérséklet összefüggése:", R.drawable.eq17),
    CorrectQuestionWithImage("Ohm törvénye:", R.drawable.eq18),
    CorrectQuestionWithImage("Joule törvénye:", R.drawable.eq19),
    CorrectQuestionWithImage("Az elektromos erők munkája:", R.drawable.eq20),
    CorrectQuestionWithImage("Eredő ellenállás soros kapcsolás esetében:", R.drawable.eq21),
    CorrectQuestionWithImage("Eredő ellenállás párhuzamos kapcsolás esetében:", R.drawable.eq22),

    CorrectQuestionWithImage("Általános Ohm - törvény:", R.drawable.eq23),
    CorrectQuestionWithImage("A generátor teljesítménye:", R.drawable.eq24),
    CorrectQuestionWithImage("A generátor Joule – féle vesztesége:", R.drawable.eq25),
    CorrectQuestionWithImage("Az áramkör hatásfoka:", R.drawable.eq26),
    CorrectQuestionWithImage("Kirchhoff első törvénye:", R.drawable.eq27),
    CorrectQuestionWithImage("Kirchhoff második törvénye:", R.drawable.eq28),
)

fun getRandomizedQuestions(): MutableList<Any> {
    val anwsersWord = correctQuestions.filter { it is CorrectQuestion }.map { (it as CorrectQuestion).correctAnwser }
    val imagesFromAnwsers = correctQuestions.filter { it is CorrectQuestionWithImage }.map { (it as CorrectQuestionWithImage).questionImage }

    val questions = correctQuestions.map {
        if(it is CorrectQuestion) {
            val correct = getRandom(1, 3)

            var anw1: String? = null
            var anw2: String? = null
            var anw3: String? = null

            when(correct) {
                1 -> anw1 = it.correctAnwser
                2 -> anw2 = it.correctAnwser
                else -> anw3 = it.correctAnwser
            }

            if(anw1 == null) anw1 = getRandomAnwser(anwsersWord, it.correctAnwser)

            if(anw2 == null)
            {
                if(anw3 == null) anw2 = getRandomAnwser(anwsersWord, it.correctAnwser)
                else anw2 = getRandomAnwser(anwsersWord, it.correctAnwser, anw1)
            }

            if(anw3 == null) anw3 = getRandomAnwser(anwsersWord, anw2, anw1)

            TextQuestion(it.question, anw1, anw2, anw3, correct)
        } else {
            val trueQuestion = getRandom(1, 2) == 1

            if(trueQuestion) {
                val imgQuestion = it as CorrectQuestionWithImage
                QuestionWithImage(imgQuestion.questionText, imgQuestion.questionImage, true)
            } else {
                val imgQuestion = it as CorrectQuestionWithImage
                QuestionWithImage(imgQuestion.questionText, getRandomAnwser(imagesFromAnwsers, imgQuestion.questionImage), false)
            }
        }
    }.toMutableList()

    questions.shuffle()

    return questions
}