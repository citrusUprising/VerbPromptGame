-> Search

== Search  ==
Search 
Routine inspection, searching suspects' body. 

-> who_to_question
= who_to_question

{who_to_question > 1:
    -> END
}

{Who will you ask for searching?|Who else will you ask for searching?}

* Mrs. Emerson
    -> mrs_emerson

* Alec
    -> alec

* Quinten
    -> quinten

= mrs_emerson
What will you ask her?

* "Mrs.Emerson, please cooperate with the work."
    "Please don't stain my dress.
    (search)
    Mrs.Emerson is wearing a new dress today, she is very well dressed and sprayed with perfume.
"
    -> who_to_question

= alec
What will you ask him?

* "Please cooperate with the work."
    "Alright alright.
    (search)
    Bloodstains were found on the cuffs and left arm, and there was a large amount of nearly dried blood on the soles of the leather shoes.
"
    -> who_to_question

= quinten
What will you ask him?

* "Please cooperate with the work."
    "Willing to do.
    (search)
    The smell of alcohol is a little heavy, the hair seems to be a little vaporous, and the body is sprayed with perfume"
    -> who_to_question